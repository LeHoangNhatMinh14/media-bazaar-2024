using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShiftRepo : IShifts
    {
        private readonly string connectionString;
        public ShiftRepo() : this(Util.connectionString) { }

        public ShiftRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddShifts(Shift shift)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string querry = "Insert into Shifts (ShiftType, peopleNeeded, shiftDate, FK_departmentID) " +
                    "Values (@ShiftType, @peopleNeeded, @shiftDate, @DepartmentID)";

                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@ShiftType", shift.shiftType);
                    command.Parameters.AddWithValue("@peopleNeeded", shift.peopleNeeded);
                    command.Parameters.AddWithValue("@shiftDate", shift.shiftDate);
                    command.Parameters.AddWithValue("@DepartmentID", shift.FK_DepartmentID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateShiftinPeriod(DateTime start, DateTime end, int departmentID, int peopleNeeded)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Shifts ([shiftType], [peopleNeeded], [shiftDate], [FK_departmentID]) " +
                               "VALUES (@ShiftType, @PeopleNeeded, @ShiftDate, @DepartmentID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    for (DateTime date = start; date <= end; date = date.AddDays(1))
                    {
                        // Iterate through different shift types for each day
                        foreach (string shiftType in new string[] { "Morning", "Evening", "Night" })
                        {
                            command.Parameters.Clear(); // Clear parameters from previous iteration
                            command.Parameters.AddWithValue("@ShiftType", shiftType);
                            command.Parameters.AddWithValue("@PeopleNeeded", peopleNeeded);
                            command.Parameters.AddWithValue("@ShiftDate", date);
                            command.Parameters.AddWithValue("@DepartmentID", departmentID);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }



        public void AssignShift(int shiftID, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string selectQuery = "SELECT peopleNeeded FROM Shifts WHERE shiftID = @shiftID";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, connection, transaction);
                    selectCmd.Parameters.AddWithValue("@shiftID", shiftID);
                    int peopleNeeded = (int)selectCmd.ExecuteScalar();

                    if (peopleNeeded > 0)
                    {
                        string updateQuery = "UPDATE Shifts SET peopleNeeded = @peopleNeeded WHERE shiftID = @shiftID";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction);
                        updateCmd.Parameters.AddWithValue("@peopleNeeded", peopleNeeded - 1);
                        updateCmd.Parameters.AddWithValue("@shiftID", shiftID);
                        updateCmd.ExecuteNonQuery();

                        string insertQuery = "INSERT INTO EmployeesOnShift (FK_shiftID, FK_employeeID) VALUES (@shiftID, @employeeID)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, connection, transaction);
                        insertCmd.Parameters.AddWithValue("@shiftID", shiftID);
                        insertCmd.Parameters.AddWithValue("@employeeID", employeeID);
                        insertCmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


        public void DeleteShifts(int ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string querry = "Delete From Shifts where shiftID = @shiftID";
                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    cmd.Parameters.AddWithValue(querry, ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Shift> GetUnassignedShifts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string querry = @"SELECT * FROM Shifts
                        WHERE shiftID NOT IN 
                            (SELECT FK_shiftID FROM EmployeesOnShift) AND peopleNeeded >= 1";

                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Shift> shifts = new List<Shift>();
                        while (reader.Read())
                        {
                            Shift shift = reader.MapToShift();
                            shifts.Add(shift);
                        }
                        return shifts;
                    }
                }
            }
        }

        public Shift GetShiftbyID(int ID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string querry = "Select * From Shifts Where shiftID = @shiftID";
                using (SqlCommand cmd = new SqlCommand(querry, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Shift shift = reader.MapToShift();
                            return shift;
                        }
                    }
                }
            }
            return null;
        }

        public List<Shift> GetShiftsofEmployee (int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string querry = "SELECT * FROM Shifts " +
                    "WHERE shiftID IN " +
                    "(SELECT FK_shiftID FROM EmployeesOnShift WHERE FK_employeeID = @employeeID);";

                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Shift> shifts = new List<Shift>();
                        while (reader.Read())
                        {
                            Shift shift = reader.MapToShift();
                            shifts.Add(shift);
                        }
                        return shifts;
                    }
                }
            }
        }

        public List<Shift> GetShiftsofDateofEmployee(int employeeID, DateTime shiftDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string querry = "  SELECT * FROM Shifts " +
                    "WHERE shiftID IN (SELECT FK_shiftID FROM EmployeesOnShift WHERE FK_employeeID = @employeeID) " +
                    "AND CONVERT(date, shiftDate) = @Date;;";

                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.Parameters.AddWithValue("@Date", shiftDate);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Shift> shifts = new List<Shift>();
                        while (reader.Read())
                        {
                            Shift shift = reader.MapToShift();
                            shifts.Add(shift);
                        }
                        return shifts;
                    }
                }
            }
        }

		public List<Shift> GetShiftByWeek(int employeeID, List<DateTime> week)
		{
			List<Shift> shifts = new List<Shift>();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string querry = "  SELECT * FROM Shifts " +
					"WHERE shiftID IN (SELECT FK_shiftID FROM EmployeesOnShift WHERE FK_employeeID = @employeeID) " +
					"AND CONVERT(date, shiftDate) = @Date;";
                foreach (DateTime date in week)
                {
                    using (SqlCommand cmd = new SqlCommand(querry, connection))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
                        cmd.Parameters.AddWithValue("@Date", date);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {
                                Shift shift = reader.MapToShift();
                                shifts.Add(shift);
                            }
                        }
                    }
                }
                return shifts;
			}
		}

        public List<Shift> GetShiftsinPeriod(DateTime start, DateTime end, string department)
        {
            List<Shift> shifts = new List<Shift>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string querry = "Select * from Shifts " +
                    "INNER JOIN [dbi504738_sb08media].[dbo].[Departments] d ON s.FK_departmentID = d.departmentID" +
                    "Where shift Convert(date, shiftDate) Between @StartDate AND @EndDate" +
                    " AND d.departmentName = @DepartmentName";
                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    cmd.Parameters.AddWithValue("@DepartmentName", department);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Shift shift = reader.MapToShift();

                        shifts.Add(shift);
                    }
                }
            }
            return shifts;
        }
	}
}

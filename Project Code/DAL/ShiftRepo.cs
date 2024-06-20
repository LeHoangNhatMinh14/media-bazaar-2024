using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public bool isEmployeeOnShift(int shiftID, int employeeID)
        {
            bool isOnShift = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM EmployeesOnShift WHERE FK_shiftID = @ShiftID AND FK_employeeID = @EmployeeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ShiftID", shiftID);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

                    int count = (int)command.ExecuteScalar();

                    isOnShift = count > 0;
                }
            }

            return isOnShift;
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



        public int AssignShift(int shiftID, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Query to find out if adding another employee exceeds the people needed.
                    string selectQuery = @"
                SELECT 
                    s.peopleNeeded, 
                    COUNT(eos.FK_employeeID) AS currentAssigned
                FROM 
                    Shifts s
                LEFT JOIN 
                    EmployeesOnShift eos ON s.shiftID = eos.FK_shiftID AND eos.FK_shiftID = @shiftID
                WHERE 
                    s.shiftID = @shiftID
                GROUP BY 
                    s.peopleNeeded";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, connection, transaction);
                    selectCmd.Parameters.AddWithValue("@shiftID", shiftID);

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int peopleNeeded = reader.GetInt32(reader.GetOrdinal("peopleNeeded"));
                            int currentAssigned = reader.GetInt32(reader.GetOrdinal("currentAssigned"));

                            if (currentAssigned < peopleNeeded)
                            {
                                // Only proceed to assign if there are still positions to fill
                                reader.Close(); // Close reader to proceed with other commands

                                string insertQuery = "INSERT INTO EmployeesOnShift (FK_shiftID, FK_employeeID) VALUES (@shiftID, @employeeID)";
                                SqlCommand insertCmd = new SqlCommand(insertQuery, connection, transaction);
                                insertCmd.Parameters.AddWithValue("@shiftID", shiftID);
                                insertCmd.Parameters.AddWithValue("@employeeID", employeeID);
                                insertCmd.ExecuteNonQuery();

                                transaction.Commit();

                                // Return the number of positions still open after this assignment
                                return peopleNeeded - (currentAssigned + 1);
                            }
                            else
                            {
                                // If no positions are available, rollback and indicate full capacity
                                transaction.Rollback();
                                return 0;
                            }
                        }
                        else
                        {
                            // If the shift doesn't exist or some unexpected condition
                            transaction.Rollback();
                            return -1;  // Can indicate an error or invalid shift ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error: " + ex.Message);
                    throw;  // Re-throw the exception after rollback
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
            List<Shift> unassignedShifts = new List<Shift>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT 
                s.shiftID,
                s.shiftType,
                s.peopleNeeded - ISNULL(COUNT(eos.FK_employeeID), 0) AS peopleStillNeeded,
                s.shiftDate,
                s.FK_departmentID
            FROM 
                Shifts s
            LEFT JOIN 
                EmployeesOnShift eos ON s.shiftID = eos.FK_shiftID
            GROUP BY 
                s.shiftID, s.shiftType, s.peopleNeeded, s.shiftDate, s.FK_departmentID
            HAVING 
                s.peopleNeeded - ISNULL(COUNT(eos.FK_employeeID), 0) > 0;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Shift shift = new Shift
                            (
                                shiftid : reader.GetInt32(reader.GetOrdinal("shiftID")),
                                shiftType: reader.GetString(reader.GetOrdinal("shiftType")),
                                peopleNeeded: reader.GetInt32(reader.GetOrdinal("peopleStillNeeded")),  // Now represents people still needed
                                shiftDate: reader.GetDateTime(reader.GetOrdinal("shiftDate")),
                                fK_DepartmentID: reader.GetInt32(reader.GetOrdinal("FK_departmentID"))
                            );
                            unassignedShifts.Add(shift);
                        }
                    }
                }
            }
            return unassignedShifts;
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
                string querry = "SELECT s.*, e.firstName + ' ' + e.lastName Name " +
                    "FROM Shifts s " +
                    "JOIN EmployeesOnShift eos ON s.shiftID = eos.FK_shiftID " +
                    "JOIN Employees e ON eos.FK_employeeID = e.employeeID " +
                    "WHERE eos.FK_employeeID = @employeeID;";

                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Shift> shifts = new List<Shift>();
                        while (reader.Read())
                        {
                            Shift shift = reader.MapToShift();
                            shift.EmployeeEmail = Convert.ToString(reader["Name"]);
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
                string querry = @"
                    SELECT s.*, d.departmentName, e.firstName + ' ' + e.lastName AS EmployeeName
                    FROM Shifts s
                    INNER JOIN Departments d ON s.FK_departmentID = d.departmentID
                    INNER JOIN Contracts c ON s.FK_departmentID = c.FK_departmentID
                    INNER JOIN Employees e ON c.FK_employeeID = e.employeeID
                    WHERE CONVERT(date, s.shiftDate) BETWEEN @StartDate AND @EndDate
                    AND d.departmentName = @DepartmentName";
                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    cmd.Parameters.AddWithValue("@DepartmentName", department);

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

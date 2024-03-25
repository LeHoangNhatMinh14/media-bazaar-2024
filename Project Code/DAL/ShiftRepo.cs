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

        public void AssignShift(int shiftID, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string querry = "Insert INTO EmployeesOnShift (FK_shiftID, FK_employeeID) Values (@shiftID, @employeeID)";
                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    cmd.Parameters.AddWithValue("@shiftID", shiftID);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    cmd.ExecuteNonQuery();
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
                            (SELECT FK_shiftID FROM EmployeesOnShift)";

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
    }
}

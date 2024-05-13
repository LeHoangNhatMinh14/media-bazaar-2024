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
    public class AvailabilityRepo : IAvailabilityDAL
    {
        private readonly string connectionString;
        public AvailabilityRepo() : this(Util.connectionString) { }
        public AvailabilityRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddUsualAvailability(Availability availability)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                string query;
                if (AlreadyHasStableAvailabilty(availability.employeeID) == true) 
                {
                    query = "UPDATE AgreedAvailability SET Monday = @monday, Tuesday = @tuesday, Wednesday = @wednesday, Thursday = @thursday, Friday = @friday, Saturday = @saturday, Sunday = @sunday, WeekNmr = @weekNmr, Accepted = @accepted  WHERE FK_EmployeeID = @employeeID";
				}
                else 
                {
                    query = "INSERT INTO AgreedAvailability (FK_EmployeeID, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, WeekNmr, Accepted) VALUES (@employeeID, @monday, @tuesday, @wednesday , @thursday, @friday, @saturday, @sunday, @weekNmr, @accepted)";
                }
                
                connection.Open();

                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@employeeID",availability.employeeID) ;
                    command.Parameters.AddWithValue("@monday",availability.monday) ;
                    command.Parameters.AddWithValue("@tuesday",availability.tuesday) ;
                    command.Parameters.AddWithValue("@wednesday",availability.wednesday) ;
                    command.Parameters.AddWithValue("@thursday",availability.thursday) ;
                    command.Parameters.AddWithValue("@friday",availability.friday) ;
                    command.Parameters.AddWithValue("@saturday",availability.saturday) ;
                    command.Parameters.AddWithValue("@sunday",availability.sunday) ;
                    command.Parameters.AddWithValue("@weeknmr",DBNull.Value) ;
                    command.Parameters.AddWithValue("@accepted", DBNull.Value) ;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void RequestAvailabilityChange(Availability availability)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO AgreedAvailability (FK_EmployeeID, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, WeekNmr, Accepted) VALUES (@employeeID, @monday, @tuesday, @wednesday , @thursday, @friday, @saturday, @sunday, @weekNmr, 0)";
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeID", availability.employeeID);
                    command.Parameters.AddWithValue("@monday", availability.monday);
                    command.Parameters.AddWithValue("@tuesday", availability.tuesday);
                    command.Parameters.AddWithValue("@wednesday", availability.wednesday);
                    command.Parameters.AddWithValue("@thursday", availability.thursday);
                    command.Parameters.AddWithValue("@friday", availability.friday);
                    command.Parameters.AddWithValue("@saturday", availability.saturday);
                    command.Parameters.AddWithValue("@sunday", availability.sunday);
                    command.Parameters.AddWithValue("@weeknmr", availability.WeekNrm);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Availability GetAvailability()
        {
            throw new NotImplementedException();
        }

        public List<Availability> GetChangeRequests()
        {
            throw new NotImplementedException();
        }


        private bool AlreadyHasStableAvailabilty(int employeeID)
        {
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM AgreedAvailability WHERE FK_EmployeeID = @employeeID";
				connection.Open();

				using (SqlCommand command = new SqlCommand(query, connection))
				{
                    command.Parameters.AddWithValue("@employeeID",employeeID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    { 
                        if (reader.Read()) 
                        { 
                            return true; 
                        }
                        return false;
                    }
				}
			}
		}

        public Availability GetAvailabilitiesofEmployee(int employeeID)
        {
            Availability availability = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string querry = "SELECT * FROM AgreedAvailability WHERE FK_EmployeeID = @employeeID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    command.Parameters.AddWithValue("@employeeID", employeeID);
                    using (SqlDataReader r = command.ExecuteReader())
                    {
                        if(r.Read())
                        {
                            availability = r.MapToAvailability();

                        }
                    }
                }
                return availability;
            }
        }
    }
}

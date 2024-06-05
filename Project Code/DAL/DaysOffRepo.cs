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
	public class DaysOffRepo: IDaysOffDAL
	{
		private readonly string connectionString;
		public DaysOffRepo() : this(Util.connectionString) { }

		public DaysOffRepo(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public void AcceptOrDecline(int employeeID, bool approved, string disapprovalReason = null)
		{
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE [dbi504738_sb08media].[dbo].[RequestDaysOff]
            SET 
                [approved] = @Approved,
                [disapprovalReason] = CASE 
                                        WHEN @Approved = 0 THEN @DisapprovalReason
                                        ELSE NULL
                                     END
            WHERE [employeeID] = @employeeID AND [approved] = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeID", employeeID);
                    command.Parameters.AddWithValue("@Approved", approved);
                    command.Parameters.AddWithValue("@DisapprovalReason", disapprovalReason ?? (object)DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

		public RequestDaysOff GetRequest(int employeeID)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = @"SELECT * FROM RequestDaysOff WHERE employeeID = @employeeID";
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@employeeID", employeeID);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							RequestDaysOff requestDaysOff = reader.MapToDaysOff();
							return requestDaysOff;
						}
						return null;
					}
				}
			}
		}

		public void RequestDaysOff(RequestDaysOff daysOffRequest)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = @"INSERT into RequestDaysOff (employeeID, reason ,startingDate ,endDate ,approved, disapprovalReason) " +
					"Values (@employeeID, @reason, @startingDate, @endDate, 0, @disaprovalReason)";
				SqlCommand command = new SqlCommand(query, connection);

				command.Parameters.AddWithValue("@employeeID", daysOffRequest.emloyeeID);
				command.Parameters.AddWithValue("@reason", daysOffRequest.reason);
				command.Parameters.AddWithValue("@startingDate", daysOffRequest.startDate);
				command.Parameters.AddWithValue("@endDate", daysOffRequest.endDate);
				command.Parameters.AddWithValue("@disaprovalReason", DBNull.Value);

				command.ExecuteNonQuery();

			}
		}

		public List<RequestDaysOff> GetRequests(bool approved)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open ();
				string querry = "";
				if (approved)
				{
					querry = "Select RDO.*, E.email FROM RequestDaysOff RDO " +
						"Inner join Employees E ON RDO.employeeID = E.employeeID " +
						"where approved = @approved";
				}
				else
				{
					querry = "Select RDO.*, E.email FROM RequestDaysOff RDO " +
						"Inner join Employees E ON RDO.employeeID = E.employeeID " +
						"where approved = @approved AND disapprovalReason IS NULL";

                }
				using (SqlCommand command = new SqlCommand(querry, connection))
				{
					List<RequestDaysOff> requests = new List<RequestDaysOff>();
					command.Parameters.AddWithValue("@approved", approved);
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							RequestDaysOff request = reader.MapToDaysOff();
							request.employeeEmail = Convert.ToString(reader["email"]);
							requests.Add(request);
						}
						return requests;
					}
                }
			}
		}

        public void Undo(int employeeID)
        {
            using (SqlConnection connection = new SqlConnection (connectionString))
			{
				connection.Open ();
				string querry = "Update RequestDaysOff where employeeID = @employeeID";
				using (SqlCommand cmd =  new SqlCommand(querry, connection))
				{
					cmd.Parameters.AddWithValue("@employeeID", employeeID);

					cmd.ExecuteNonQuery();
				}
			}
        }
    }
}

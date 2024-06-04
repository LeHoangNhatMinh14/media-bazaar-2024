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

		public void AcceptOrDecline()
		{
			throw new NotImplementedException();
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
	}
}

using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using DAL.Mapper;
using System.Data.SqlClient;

namespace DAL
{
    public class ContractRepo
    {
        private readonly string connectionString;
        public ContractRepo() : this(Util.connectionString) { }

        public ContractRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Contract GetContract(int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Contracts WHERE employeeID = @employeeID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeID", employeeID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Contract contract = reader.MapToContract();
                            return contract;
                        }
                        return null;
                    }
                }
            }
        }

    }
}

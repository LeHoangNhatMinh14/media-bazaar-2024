using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using DAL.Mapper;
using System.Data.SqlClient;

namespace DAL
{
    public class ContractRepo : IContractsDAL
    {
        private readonly string connectionString;
        public ContractRepo() : this(Util.connectionString) { }

        public ContractRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void AddContract(Contract contract)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Contracts (contractType, workHours, position, FK_DepartmentID, active, FK_EmployeeID, startTime, endTime, reason) VALUES (@contractType, @workHours, @position, @FK_DepartmentID, @active, @FK_employeeID, @startTime, @endTime, @reason)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@contractType", contract.contractType);
                    command.Parameters.AddWithValue("@workHours", contract.workHours);
                    command.Parameters.AddWithValue("@position", contract.position);
                    command.Parameters.AddWithValue("@FK_DepartmentID", contract.departmentID);
                    command.Parameters.AddWithValue("@active", contract.active);
                    command.Parameters.AddWithValue("@FK_employeeID", contract.employeeID);
                    command.Parameters.AddWithValue("@startTime", contract.startDate);
                    if(contract.endDate != null)
                        command.Parameters.AddWithValue("@endTime", contract.endDate);
                    if(contract.reason != null)
                        command.Parameters.AddWithValue("@reason", contract.reason);
                    command.ExecuteNonQuery();
                }
            }
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

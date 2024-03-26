using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using DAL.Mapper;
using System.Data.SqlClient;

namespace DAL
{
    public class EmployeeRepo : IEmployeeDAL
    {
        private readonly string connectionString;

        public EmployeeRepo() : this(Util.connectionString) { }

        public EmployeeRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Employee> GetAllEmployees() {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Employees";
                connection.Open();
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Employee> employeeslist = new List<Employee>();
                        while(reader.Read())
                        {
                            Employee employee = reader.MapToEmployee();
                            employeeslist.Add(employee);
                        }
                        return employeeslist;
                    }
                }
            }
        }

		public Employee GetEmployee(string email , string password)
		{
            if (VerifyLogin(email, password))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT * FROM Employees WHERE email = @email AND password = @password";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Employee employee = reader.MapToEmployee();
                                return employee;
                            }
                            return null;
                        }
                    }
                }
            }
            return null;
		}

        public Employee GetEmployeeByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Employees WHERE employeeID = @employeeID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeID", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Employee employee = reader.MapToEmployee();
                            return employee;
                        }
                        return null;
                    }
                }
            }
        }

        public void AddEmployee (Employee employee)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT into Employees (firstName, lastName, bsn, dateOfBirth, phoneNumber, gender, email, city, country ,street, houseNumber, postalCode, emergencyContactName, emergencyPhoneNumber, emergencyRelation, password, firstLogin) " +
                    "Values (@firstName, @lastName, @bsn, @dateOfBirth, @phoneNumber, @gender, @email, @city, @country, @street, @houseNumber, @postalCode, @emergencyContactName, @emergencyPhoneNumber, @emergencyRelation, @password, @firstLogin)";
                SqlCommand command = new SqlCommand(query, connection);
                
                    command.Parameters.AddWithValue("@firstName", employee.firstName);
                    command.Parameters.AddWithValue("@lastName", employee.lastName);
                    command.Parameters.AddWithValue("@bsn", employee.bsn);
                    command.Parameters.AddWithValue("@dateOfBirth", employee.dateOfBirth.ToString());
                    command.Parameters.AddWithValue("@phoneNumber", employee.phoneNumber);
                    command.Parameters.AddWithValue("@gender", employee.gender);
                    command.Parameters.AddWithValue("@email", employee.email);
                    command.Parameters.AddWithValue("@city", employee.city);
                    command.Parameters.AddWithValue("@country", employee.country);
                    command.Parameters.AddWithValue("@street", employee.street);
                    command.Parameters.AddWithValue("@houseNumber", employee.houseNumber);
                    command.Parameters.AddWithValue("@postalCode", employee.postalCode);
                    command.Parameters.AddWithValue("@emergencyContactName", employee.emergencyContactName);
                    command.Parameters.AddWithValue("@emergencyPhoneNumber", employee.emergencyPhoneNumber);
                    command.Parameters.AddWithValue("@emergencyRelation", employee.emergencyRelation);
                    command.Parameters.AddWithValue("@password", employee.password);
                    command.Parameters.AddWithValue("@firstLogin", employee.firstLogin);
                    command.ExecuteNonQuery();
                
            }
        }
        //We Do not actually delete we just make contract active go to false need to still update this on DB
        public void DeleteEmployee (Employee employee)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Contract SET active = false WHERE employeeID = @employeeid ";
                using(SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@employeeid", employee.employeeID);
                }
            }
        }

        public bool VerifyLogin(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Example query - adjust according to your database schema
                string query = @"SELECT COUNT(1) FROM Employees WHERE email = @email AND password = @password";

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public void EditEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Employee SET firstName = @firstName,
                                                    lastName = @lastName, 
                                                    bsn = @bsn, 
                                                    dateOfBirth = @dateOfBirth,
                                                    phoneNumber = @phoneNumber, gender, email, city, country ,street, houseNumber, postalCode, emergencyContactName, emergencyPhoneNumber, emergencyRelation, password, firstLogin WHERE employeeID = @employeeid ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeid", employee.employeeID);
                }
            }
        }
    }
}

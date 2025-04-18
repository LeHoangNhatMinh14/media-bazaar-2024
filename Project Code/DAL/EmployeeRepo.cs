﻿using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using DAL.Mapper;
using System.Data.SqlClient;
using System.Security.Principal;

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

        public List<Employee> GetAllEmployees()
        {
            ContractRepo contractRepo = new ContractRepo(connectionString);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Employees";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Employee> employeeslist = new List<Employee>();
                        while (reader.Read())
                        {
                            Employee employee = reader.MapToEmployee();
                            employee.Contract = contractRepo.GetContract(employee.employeeID);
                            employeeslist.Add(employee);
                        }
                        return employeeslist;
                    }
                }
            }
        }

        public Employee GetEmployee(string email , string password)
		{

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
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
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return default;
            }   
                
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

        public void AddEmployee (Employee employee, string position)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query;
                if (position == "Manager")
                {
                    query = @"INSERT into Employees (firstName, lastName, bsn, dateOfBirth, phoneNumber, gender, email, city, country ,street, houseNumber, postalCode, emergencyContactName, emergencyPhoneNumber, emergencyRelation, password, firstLogin, role) " +
                            "Values (@firstName, @lastName, @bsn, @dateOfBirth, @phoneNumber, @gender, @email, @city, @country, @street, @houseNumber, @postalCode, @emergencyContactName, @emergencyPhoneNumber, @emergencyRelation, @password, @firstLogin, @role)";
                }
                else
                {
                     query = @"INSERT into Employees (firstName, lastName, bsn, dateOfBirth, phoneNumber, gender, email, city, country ,street, houseNumber, postalCode, emergencyContactName, emergencyPhoneNumber, emergencyRelation, password, firstLogin) " +
                            "Values (@firstName, @lastName, @bsn, @dateOfBirth, @phoneNumber, @gender, @email, @city, @country, @street, @houseNumber, @postalCode, @emergencyContactName, @emergencyPhoneNumber, @emergencyRelation, @password, @firstLogin)";
                }

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
                if (position == "Manager")
                {
                    command.Parameters.AddWithValue("@role", position);
                }
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

        public (string role, string department) VerifyLogin(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT E.role , d.departmentName 
                                    FROM Employees E 
                                    Inner join Contracts c on E.employeeID = c.FK_employeeID
                                    Inner join Departments d on c.FK_departmentID = d.departmentID
                                    WHERE email = @email AND password = @password;";

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["role"] as string;
                            string department = reader["departmentName"] as string;
                            return (role, department);
                        }
                    }
                }
            }
            return (null, null); 
        }

        public void EditEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try { 
                connection.Open();

                string query = @"UPDATE Employees SET firstName = @firstName,
                                        lastName = @lastName, 
                                        bsn = @bsn, 
                                        dateOfBirth = @dateOfBirth,
                                        phoneNumber = @phoneNumber,
                                        gender = @gender,
                                        email = @email,
                                        city = @city,
                                        country = @country,
                                        street = @street, 
                                        houseNumber = @houseNumber, 
                                        postalCode = @postalCode,
                                        emergencyContactName = @emergencyContactName, 
                                        emergencyPhoneNumber = @emergencyPhoneNumber,
                                        emergencyRelation = @emergencyRelation,
                                        password = @password, 
                                        firstLogin = @firstLogin
                                        WHERE employeeID = @employeeid ";


                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@employeeid", employee.employeeID);
                command.Parameters.AddWithValue("@firstName", employee.firstName);
                command.Parameters.AddWithValue("@lastName", employee.lastName);
                command.Parameters.AddWithValue("@bsn", employee.bsn);
                command.Parameters.AddWithValue("@dateOfBirth", employee.dateOfBirth);
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
                command.Parameters.AddWithValue("@firstLogin", false);
                command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public void EditEmployee(Employee employee, string position)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE Employees SET firstName = @firstName,
                                        lastName = @lastName, 
                                        bsn = @bsn, 
                                        dateOfBirth = @dateOfBirth,
                                        phoneNumber = @phoneNumber,
                                        gender = @gender,
                                        email = @email,
                                        city = @city,
                                        country = @country,
                                        street = @street, 
                                        houseNumber = @houseNumber, 
                                        postalCode = @postalCode,
                                        emergencyContactName = @emergencyContactName, 
                                        emergencyPhoneNumber = @emergencyPhoneNumber,
                                        emergencyRelation = @emergencyRelation,
                                        password = @password, 
                                        firstLogin = @firstLogin,
                                        role = @role
                                        WHERE employeeID = @employeeid ";


                SqlCommand command = new SqlCommand(query, connection);
                
                    command.Parameters.AddWithValue("@employeeid", employee.employeeID);
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
                    command.Parameters.AddWithValue("@role", position);
                    command.ExecuteNonQuery();
                
            }
        }

        public Employee GetRecentEmployee()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"Select Top 1 *
                                From Employees
                                Order by employeeID DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

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

        public List<Employee> GetEmployeesbyDepartment(string department)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                ContractRepo contractRepo = new ContractRepo(connectionString);
                string querry = "  Select E.* From Employees E " +
                    "inner join Contracts c ON e.employeeID = c.FK_employeeID " +
                    "inner join Departments d on d.departmentID = c.FK_departmentID " +
                    "where d.departmentName = @department";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(querry, connection))
                {
                    cmd.Parameters.AddWithValue("@department", department);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        List<Employee> employeeslist = new List<Employee>();
                        while (rdr.Read())
                        {
                            Employee employee = rdr.MapToEmployee();
                            employee.Contract = contractRepo.GetContract(employee.employeeID);
                            employeeslist.Add(employee);
                        }
                        return employeeslist;
                    }
                }
            }
        }
    }
}

﻿using BusinessLogicLayer.Class;
using DAL.Mapper;
using System.Data.SqlClient;

namespace DAL
{
    public class EmployeeRepo
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
                string query = @"SELECT employeeID, firstName,lastName,bsn,dateOfBirth,phoneNumber,gender,email,city, street, houseNumber, postalCode, emergencyContactName,emergencyPhoneNumber,emergencyRelation FROM Employees";
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


        public void AddEmployee (Employee employee)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO....";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        //We Do not actually delete we just make contract active go to false need to still update this on DB
        public void DeleteEmployee (Employee employee)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Contract SET active = false WHERE EmployeeID = @employeeid ";
                using(SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@employeeid", employee.employeeID);
                }
            }
        }


    }
}

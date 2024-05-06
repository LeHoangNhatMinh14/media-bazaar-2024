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
    public class DepartmentRepo : IDepartments
    {
        private readonly string connectionString;
        public DepartmentRepo() : this(Util.connectionString) { }

        public DepartmentRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void AddDepartment(string departmentName)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string querry = "INSERT INTO Departments (departmentName) VALUES (@departmentName)";
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(querry, conn))
                {
                    cmd.Parameters.AddWithValue("@departmentName", departmentName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteDepartment(int departmentID)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string querry = "DELETE FROM Departments WHERE departmentID = @departmentID";
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(querry, conn))
                {
                    cmd.Parameters.AddWithValue("@departmentID", departmentID);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<Department> GetDepartments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string querry = "SELECT * From Departments";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(querry, conn))
                {
                    List<Department> departments = new List<Department>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           Department department = reader.MapToDepartment();
                            departments.Add(department);
                        }
                        return departments;
                    }
                }
            }
        }

        public string GetDepartmentName(int departmentID)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "SELECT * FROM Departments WHERE departmentID = @departmentid";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
					command.Parameters.AddWithValue("@departmentid", departmentID);

					using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            return reader["departmentName"].ToString();
                        }
                    }
                    return null;
                }
            }
        }
        public int GetDepartmentID(string departmentName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT departmentID FROM Departments WHERE departmentName = @departmentName";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@departmentName", departmentName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return (int)reader["departmentID"];
                        }
                    }
                    return 0;
                }
            }
        }
    }
}

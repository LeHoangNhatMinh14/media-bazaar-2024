using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
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
                            int id = Convert.ToInt32(reader["departmentID"]);
                            string Name = Convert.ToString(reader["departmentName"]);

                            Department department = new Department(id, Name);
                            departments.Add(department);
                        }
                        return departments;
                    }
                }
            }
        }
    }
}

using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ManageClass
{
    public class ManageDepartment
    {
        private List<Department> departmentList;

        public ManageDepartment() 
        {
            departmentList = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            // add department to the database
            departmentList.Add(department);
        }

        public List<Department> GetDepartmentList()
        {
            return departmentList;
        }

        public void DeleteDepartment()
        {
            // delete department
        }
    }
}

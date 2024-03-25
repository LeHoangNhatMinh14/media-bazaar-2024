using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
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
        private IDepartments _departments;

        public ManageDepartment(IDepartments departments) 
        {
            departmentList = new List<Department>();
            _departments = departments;
        }

        public void AddDepartment(Department department)
        {
            // add department to the database
            departmentList.Add(department);
        }

        public List<Department> GetDepartmentList()
        {
            departmentList = _departments.GetDepartments();
            return departmentList;
        }

        public void DeleteDepartment()
        {
            // delete department
        }
    }
}

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

        public void AddDepartment(string departmentName)
        {
           _departments.AddDepartment(departmentName);
        }

        public List<Department> GetDepartmentList()
        {
            return _departments.GetDepartments();
        }
        public string GetDepartmentName(int departmentID) { 
        return _departments.GetDepartmentName(departmentID);
        }
    }
}

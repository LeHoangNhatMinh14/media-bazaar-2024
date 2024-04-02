using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IDepartments
    {
        List<Department> GetDepartments();
        void AddDepartment(string departmentName);
        void DeleteDepartment(int departmentID);
        string GetDepartmentName(int departmentID);
    }
}

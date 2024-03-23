using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IEmployeeDAL
    {

        List<Employee> GetAllEmployees();

        void AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

    }
}

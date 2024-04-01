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

        Employee GetEmployee(string email , string password);

        Employee GetEmployeeByID(int id);

        void AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        bool VerifyLogin(string userName , string password);

        void EditEmployee(Employee employee);

    }
}

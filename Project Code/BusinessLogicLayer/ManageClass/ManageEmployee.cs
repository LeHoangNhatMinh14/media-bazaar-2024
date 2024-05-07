using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ManageClass
{
    public class ManageEmployee
    {
        private List<Employee> employees;
        private IEmployeeDAL dataAccessLayer;

        public ManageEmployee(IEmployeeDAL dAL)
        {
            dataAccessLayer = dAL;
            employees = GetAllEmployees();

        }

        public void AddEmployee(Employee employee)
        {
            
            //Add employee to database
            dataAccessLayer.AddEmployee(employee);
            employees.Add(employee);
        }

        public void EditEmployee(Employee employee)
        {
            //Edit Employee in the database
        }

        public void DeleteEmployee(Employee employee)
        {
            //Delete Employee in the database or maybe somehow to make the account inactive
            dataAccessLayer.DeleteEmployee(employee);
        }

        public Employee GetEmployee(string email ,string password)
        {
            Employee employee = dataAccessLayer.GetEmployee(email , password);
            return employee;
        }

        public Employee GetEmployeeByID(int id)
        { 
            Employee employee = dataAccessLayer.GetEmployeeByID(id);
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            employees = dataAccessLayer.GetAllEmployees();
            return employees;
        }

        public List<Employee> GetEmployeeofDepartment(string department)
        {
            employees = dataAccessLayer.GetEmployeessbyDepartment(department);
        }
    }
}

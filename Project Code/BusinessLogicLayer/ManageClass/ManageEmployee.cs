using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ManageClass
{
    public class ManageEmployee
    {
        private List<Employee> employees;

        public ManageEmployee()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            //Add employee to database
            employees.Add(employee);
        }

        public void EditEmployee(Employee employee)
        {
            //Edit Employee in the database
        }

        public void DeleteEmployee(Employee employee)
        {
            //Delete Employee in the database or maybe somehow to make the account inactive
        }

        public Employee GetEmployee(int employeeID)
        {
            // get specific employee using the ID
            return null;
        }

        public List<Employee> GetEmployees()
        {
            //Get all employee
            return employees;
        }

        
    }
}

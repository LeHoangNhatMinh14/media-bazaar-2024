using BusinessLogicLayer.Class;

namespace DAL
{
    public interface IEmployeeRepo
    {
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        void EditEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        Employee GetEmployee(string email, string password);
        Employee GetEmployeeByID(int id);
        string VerifyLogin(string email, string password);
    }
}
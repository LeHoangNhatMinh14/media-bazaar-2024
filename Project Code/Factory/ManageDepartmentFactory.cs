using BusinessLogicLayer.ManageClass;
using DAL;

namespace Factory
{
    public class ManageDepartmentFactory
    {
        public static ManageDepartment manageDepartment;
        public static ManageDepartment Create()
        {
            if (manageDepartment == default)
            {
                manageDepartment = new (new DepartmentRepo());
            }
            return manageDepartment;
        }
    }
}

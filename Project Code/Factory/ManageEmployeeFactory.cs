using BusinessLogicLayer.ManageClass;
using DAL;

namespace Factory
{
    public static class ManageEmployeeFactory
    {
        private static ManageEmployee manageEmployee;
        public static ManageEmployee Create()
        {
            if (manageEmployee == default)
            {
                manageEmployee = new(new EmployeeRepo());
            }
            return manageEmployee;
        }

    }
}

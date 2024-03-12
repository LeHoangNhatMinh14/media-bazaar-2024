namespace DAL
{
    public class EmployeeRepo
    {
        private readonly string connectionString;
        public EmployeeRepo() : this(Util.connectionString) { }

        public EmployeeRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }


    }
}

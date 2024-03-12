using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepo
    {
        private readonly string connectionString;
        public DepartmentRepo() : this(Util.connectionString) { }

        public DepartmentRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}

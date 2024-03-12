using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShiftRepo
    {
        private readonly string connectionString;
        public ShiftRepo() : this(Util.connectionString) { }

        public ShiftRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}

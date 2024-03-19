using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContractRepo
    {
        private readonly string connectionString;
        public ContractRepo() : this(Util.connectionString) { }

        public ContractRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}

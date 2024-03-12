using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        private readonly string connectionString;
        public ProductRepo() : this(Util.connectionString) { }

        public ProductRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}

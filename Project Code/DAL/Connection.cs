using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection : IConnection
    {
        private readonly string connectionString;

        public Connection(IConfiguration configuration)
        {

            this.connectionString = connectionString;
        }


        private SqlConnection CreateConnection()
        {
            return new SqlConnection("Data Source = Server=mssqlstud.fhict.local;Database=dbi504738_sb08media;User Id=dbi504738_sb08media;Password=seNthOusHInv;");
        }

        public SqlConnection ConnectionObject
        {
            get { return CreateConnection(); }
        }
    }

    public interface IConnection
    {
    }
}
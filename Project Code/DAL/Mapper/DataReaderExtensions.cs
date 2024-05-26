using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public static class DataReaderExtensions
    {
        public static Product MapToProduct(this SqlDataReader reader)
        {
            return new Product
            {
                ProductId = reader.GetInt32(0),
                Name = reader.GetString(1),
                Category = reader.GetString(2),
                BuyingPrice = reader.GetDecimal(3),
                SellingPrice = reader.GetDecimal(4),
                Stock = reader.GetInt32(5)
            };
        }
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Class;

namespace DAL
{
    public class StockRepo : IStockRepo1
    {
        private readonly string connectionString;

        public StockRepo() : this(Util.connectionString) { }

        public StockRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Stock> GetAllStock()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Stock";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Stock> stockList = new List<Stock>();
                        while (reader.Read())
                        {
                            Stock stock = new Stock
                            {
                                ProductId = reader.GetInt32(0),
                                Quantity = reader.GetInt32(1),
                                LastUpdated = reader.GetDateTime(2)
                            };
                            stockList.Add(stock);
                        }
                        return stockList;
                    }
                }
            }
        }

        public Stock GetStockByProductId(int productId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Stock WHERE ProductId = @productId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Stock
                            {
                                ProductId = reader.GetInt32(0),
                                Quantity = reader.GetInt32(1),
                                LastUpdated = reader.GetDateTime(2)
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public void AddStock(int productId, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Stock 
                                SET Quantity = Quantity + @quantity, LastUpdated = @lastUpdated 
                                WHERE ProductId = @productId;
                                IF @@ROWCOUNT = 0
                                INSERT INTO Stock (ProductId, Quantity, LastUpdated) 
                                VALUES (@productId, @quantity, @lastUpdated)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@lastUpdated", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ReduceStock(int productId, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Stock 
                                SET Quantity = Quantity - @quantity, LastUpdated = @lastUpdated 
                                WHERE ProductId = @productId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@lastUpdated", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}


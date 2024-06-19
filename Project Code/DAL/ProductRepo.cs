using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<Product> GetAllProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Products";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Product> products = new List<Product>();
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Category = reader.GetString(2),
                                BuyingPrice = reader.GetDecimal(3),
                                SellingPrice = reader.GetDecimal(4),
                                Stock = reader.GetInt32(5)
                            };
                            products.Add(product);
                        }
                        return products;
                    }
                }
            }
        }

        public Product GetProductById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Products WHERE ProductId = @productId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
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
                        return null;
                    }
                }
            }
        }

        public void AddProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Products (Name, Category, BuyingPrice, SellingPrice, Stock) 
                                VALUES (@name, @category, @buyingPrice, @sellingPrice, @stock)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@category", product.Category);
                    command.Parameters.AddWithValue("@buyingPrice", product.BuyingPrice);
                    command.Parameters.AddWithValue("@sellingPrice", product.SellingPrice);
                    command.Parameters.AddWithValue("@stock", product.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Products 
                                SET Name = @name, 
                                    Category = @category, 
                                    BuyingPrice = @buyingPrice, 
                                    SellingPrice = @sellingPrice, 
                                    Stock = @stock 
                                WHERE ProductId = @productId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", product.ProductId);
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@category", product.Category);
                    command.Parameters.AddWithValue("@buyingPrice", product.BuyingPrice);
                    command.Parameters.AddWithValue("@sellingPrice", product.SellingPrice);
                    command.Parameters.AddWithValue("@stock", product.Stock);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"DELETE FROM Products WHERE ProductId = @productId";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productId", productId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
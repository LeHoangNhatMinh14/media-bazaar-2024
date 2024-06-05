using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataExecutor
    {
        private readonly Connection _connection;

        public DataExecutor(Connection connection)
        {
            _connection = connection;
        }
        public async Task ExecuteNonQueryAsync(string query, Dictionary<string, object> parameters, bool isStoredProcedure = false)
        {
            using (SqlConnection conn = _connection.ConnectionObject)
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (isStoredProcedure)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                foreach (var parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                await conn.OpenAsync();

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public async Task<List<T>> ExecuteQueryAsync<T>(string query, Dictionary<string, object> parameters, Func<SqlDataReader, T> mapFunction, bool isStoredProcedure = false)
        {
            List<T> results = new List<T>();

            using (SqlConnection conn = _connection.ConnectionObject)
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (isStoredProcedure)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                foreach (var parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                await conn.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        results.Add(mapFunction(reader));
                    }
                }
            }
            return results;
        }



        public async Task<T> ExecuteScalarAsync<T>(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = _connection.ConnectionObject)
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                await conn.OpenAsync();

                try
                {
                    object result = await cmd.ExecuteScalarAsync();
                    return result is DBNull ? default : (T)result;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    return default;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return default;
                }
            }
        }



        public async Task ExecuteStoredProcedureAsync(string storedProcedureName, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = _connection.ConnectionObject)
            using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (var parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }

                await conn.OpenAsync();

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

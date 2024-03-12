using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    internal static class Mapping
    {
        private static T? GetValue<T>(SqlDataReader dataReader, string key)
        {
            if (dataReader.IsDBNull(key))
            {
                return default;
            }
            return dataReader.GetFieldValue<T>(key);
        }

        private static string GetStringValue(SqlDataReader dataReader, string key)
        {
            return GetValue<string>(dataReader, key) ?? string.Empty;
        }


        internal static Employee MapToEmployee(this SqlDataReader dataReader)
        {
            return new Employee(
                employeeID: GetValue<int>(dataReader, nameof(Employee.employeeID)),
                bsn: GetValue<int>(dataReader, nameof(Employee.bsn)),
                email: GetStringValue(dataReader,nameof(Employee.email)))
            {
                firstName = GetStringValue(dataReader, nameof(Employee.firstName)),
                lastName = GetStringValue(dataReader, nameof(Employee.lastName)),

            }
            
                

            
        }
    }
}

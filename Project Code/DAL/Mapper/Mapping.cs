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
                bsn: GetStringValue(dataReader, nameof(Employee.bsn)),
                email: GetStringValue(dataReader, nameof(Employee.email)))
            {
                firstName = GetStringValue(dataReader, nameof(Employee.firstName)),
                lastName = GetStringValue(dataReader, nameof(Employee.lastName)),
                dateOfBirth = GetValue<DateTime>(dataReader, nameof(Employee.dateOfBirth)),
                phoneNumber = GetStringValue(dataReader, nameof(Employee.phoneNumber)),
                gender = GetStringValue(dataReader, nameof(Employee.gender)),
                city = GetStringValue(dataReader, nameof(Employee.city)),
                country = GetStringValue(dataReader, nameof(Employee.country)),
                street = GetStringValue(dataReader, nameof(Employee.street)),
                houseNumber = GetValue<int>(dataReader, nameof( Employee.houseNumber)),
                postalCode = GetStringValue(dataReader,nameof(Employee.postalCode)),
                emergencyContactName = GetStringValue(dataReader, nameof(Employee.emergencyContactName)),
                emergencyPhoneNumber = GetStringValue(dataReader,nameof(Employee.emergencyPhoneNumber)),
                emergencyRelation = GetStringValue(dataReader, $"{nameof(Employee.emergencyRelation)}"),
                password = GetStringValue(dataReader, nameof(Employee.password)),
                firstLogin = GetValue<bool>(dataReader, nameof(Employee.firstLogin))
            };
        }

        internal static Contract MapToContract (this SqlDataReader dataReader)
        {
            return new Contract(
                contractID: GetValue<int>(dataReader, nameof(Contract.contractID)),
                employeeID: GetValue<int>(dataReader, nameof(Contract.employeeID)))
            {
                contractType = GetStringValue(dataReader, nameof(Contract.contractType)),
                workHours = GetStringValue(dataReader, nameof(Contract.workHours)),
                position = GetStringValue(dataReader, nameof(Contract.position)),
                active = GetValue<bool>(dataReader, nameof(Contract.active)),
                startDate = GetValue<DateTime>(dataReader, nameof(Contract.startDate)),
                endDate = GetValue<DateTime>(dataReader, nameof(Contract.endDate)),
                reason = GetStringValue(dataReader, nameof(Contract.reason))
            };
        }

        internal static Shift MapToShift (this SqlDataReader dataReader)
        {
            return new Shift(
                shiftid: GetValue<int>(dataReader, nameof(Shift.shiftid)))
            {
                shiftType = GetStringValue(dataReader, nameof(Shift.shiftType)),
                peopleNeeded = GetValue<int>(dataReader, nameof(Shift.peopleNeeded)),
                shiftDate = GetValue<DateTime>(dataReader, nameof(Shift.shiftDate)),
                FK_DepartmentID = GetValue<int>(dataReader, nameof(Shift.FK_DepartmentID))
            };
        }
    }
}

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
                employeeID: GetValue<int>(dataReader, "FK_employeeID"))
            {
                contractType = GetStringValue(dataReader, nameof(Contract.contractType)),
                workHours = GetStringValue(dataReader, nameof(Contract.workHours)),
                position = GetStringValue(dataReader, nameof(Contract.position)),
                active = GetValue<bool>(dataReader, nameof(Contract.active)),
                departmentID = GetValue<int>(dataReader, "FK_departmentID"),
                startDate = GetValue<DateTime>(dataReader, "startTime"),
                endDate = GetValue<DateTime>(dataReader, "endTime"),
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

        internal static Department MapToDepartment (this SqlDataReader dataReader)
        {
            return new Department(departmentID : GetValue<int>(dataReader, "departmentID"))
            {
                _departmentName = GetStringValue(dataReader, "departmentName")
            };
        }

        internal static RequestDaysOff MapToDaysOff(this SqlDataReader dataReader)
        {
            return new RequestDaysOff(emloyeeID: GetValue<int>(dataReader, "employeeID"))
            {
                startDate = GetValue<DateTime>(dataReader,"startingDate"),
                endDate = GetValue<DateTime>(dataReader,"endDate"),
                approved = GetValue<bool>(dataReader,"approved"),
                disapprovalReason = GetStringValue(dataReader, "disapprovalReason")
            };
        }

        internal static Availability MapToAvailability(this SqlDataReader dataReader)
        {
            return new Availability()
            {
                employeeID = GetValue<int>(dataReader, "FK_EmployeeID"),
                WeekNrm = GetValue<int?>(dataReader, "WeekNmr"),
                monday = GetValue<bool>(dataReader, "Monday"),
                tuesday = GetValue<bool>(dataReader, "Tuesday"),
                wednesday = GetValue<bool>(dataReader, "Wednesday"),
                thursday = GetValue<bool>(dataReader, "Thursday"),
                friday = GetValue<bool>(dataReader, "Friday"),
                saturday = GetValue<bool>(dataReader, "Saturday"),
                sunday = GetValue<bool>(dataReader, "Sunday"),
                accepted = GetValue<bool>(dataReader, "Accepted")
            };
        }
    }
}

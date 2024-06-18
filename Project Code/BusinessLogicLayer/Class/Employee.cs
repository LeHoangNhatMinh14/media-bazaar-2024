using System.Diagnostics.Metrics;
using System.IO;
using System.Reflection;

namespace BusinessLogicLayer.Class
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string bsn { get; private set; } = string.Empty;
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string gender { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public string street { get; set; } = string.Empty;
        public int houseNumber { get; set; }
        public string postalCode { get; set; } = string.Empty;
        public string emergencyPhoneNumber { get; set; }
        public string emergencyContactName { get; set; } = string.Empty;
        public string emergencyRelation { get; set; } = string.Empty;
        public string Role { get; set; }  
        public Contract Contract { get; set; }

        public string password { get; set; } = string.Empty;
        public bool firstLogin { get; set; }

        RandomizePassword random = new RandomizePassword();

        public string EmployeeInfo => $"{firstName} {lastName}";
        public string EmployeeAddress => $"{street} {houseNumber} {postalCode}";

        public Employee(){}
        // new employee add to database
        public Employee(string firstName, string lastName, string password, string bsn, DateTime dateOfBirth, string phoneNumber, string gender, string email, string city, string country, string street, int houseNumber, string postalCode, string emergencyContactName, string emergencyPhoneNumber, string emergencyRelation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.bsn = bsn;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.email = email;
            this.city = city;
            this.country = country;
            this.street = street;
            this.houseNumber = houseNumber;
            this.postalCode = postalCode;
            this.emergencyContactName = emergencyContactName;
            this.emergencyPhoneNumber = emergencyPhoneNumber;
            this.emergencyRelation = emergencyRelation;
            //this.Contract = contract;
            this.password = random.GeneratePassword(8);
            this.firstLogin = true;
        }


        //For Mapper
        public Employee(int employeeID, string bsn, string email)
        {
            this.employeeID = employeeID;
            this.bsn = bsn;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.city = city;
            this.country = country;
            this.street = street;
            this.houseNumber = houseNumber;
            this.postalCode = postalCode;
            this.emergencyContactName = emergencyContactName;
            this.emergencyPhoneNumber = emergencyPhoneNumber;
            this.emergencyRelation = emergencyRelation;
            this.Contract = Contract;
            this.password = password;
            this.firstLogin = firstLogin;
        }

        public override string ToString()
        {
            return $"{employeeID} - {firstName} {lastName}";
        }


    }
}
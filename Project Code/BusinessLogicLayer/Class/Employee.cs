using System.Diagnostics.Metrics;
using System.IO;
using System.Reflection;

namespace BusinessLogicLayer.Class
{
    public class Employee
    {
        public int employeeID { get; private set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string bsn { get; private set; } = string.Empty;
        public DateOnly dateOfBirth {  get; set; } 
        public int phoneNumber { get; set; }
        public string gender { get; set; } = string.Empty;
        public string email { get; private set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public string street { get; set; } = string.Empty;
        public int houseNumber { get; set; }
        public string postalCode { get; set; } = string.Empty;
        public int emergencyPhoneNumber { get; set; }
        public string emergencyContactName { get; set; } = string.Empty;
        public string emergencyRelation { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;    
        public bool firstLogin { get; set; }
        

        public Employee(int employeeID, string firstName, string lastName, string bsn, DateOnly dateOfBirth, int phoneNumber, string gender, string email, string city, string country, string street, int houseNumber, string postalCode, string emergencyContactName, int emergencyPhoneNumber, string emergencyRelation)
        {
            this.employeeID = employeeID;
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
            this.password = password;
            this.firstLogin = true;
        }


        //For Mapper
        public Employee(int employeeID, int bsn, string email)
        {
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
            this.password = password;
            this.firstLogin = firstLogin;
        }



    }
}
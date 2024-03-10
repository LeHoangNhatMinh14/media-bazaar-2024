namespace BusinessLogicLayer.Class
{
    public class Employee
    {
        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private string _bsn;
        private DateOnly _dateOfBirth;
        private int _phoneNumber;
        private string _gender;
        private string _email;
        private string _city;
        private string _country;
        private string _street;
        private int _houseNumber;
        private string _postalCode;
        private string _emergencyContactName;
        private int _emergencyPhoneNumber;
        private string _emergencyRelation;
        private string _password;
        private bool _firstLogin;

        public Employee(int employeID, string firstName, string lastName, string bsn, DateOnly dateOfBirth, int phoneNumber, string gender, string email, string city, string country, string street, int houseNumber, string postalCode, string emergencyContactName, int emergencyPhoneNumber, string emergencyRelation)
        {
            _employeeID = employeID;
            _firstName = firstName;
            _lastName = lastName;
            _bsn = bsn;
            _dateOfBirth = dateOfBirth;
            _phoneNumber = phoneNumber;
            _gender = gender;
            _email = email;
            _city = city;
            _country = country;
            _street = street;
            _houseNumber = houseNumber;
            _postalCode = postalCode;
            _emergencyContactName = emergencyContactName;
            _emergencyPhoneNumber = emergencyPhoneNumber;
            _emergencyRelation = emergencyRelation;
            // password random?
            _password = "test";
            _firstLogin = false;
        }

        public string Name
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
            private set
            {
               // nothing
            }
        }

        public string Address
        {
            get
            {
                return $"{_street} {_houseNumber} {_postalCode} {_city} {_country}";
            }
            set
            {
                // nothing
            }
        }

        public override string ToString()
        {
            return $"{_employeeID} - {_firstName} {_lastName}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Class
{
    public class Department
    {
        public int _departmentID { get; set; }
        public string _departmentName { get; set; }

        public Department(int departmentID, string departmentName)
        {
            _departmentID = departmentID;
            _departmentName = departmentName;
        }

        public override string ToString()
        {
            return $"{_departmentName}";
        }
    }
}

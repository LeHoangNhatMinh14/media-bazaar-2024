using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Class
{
    public class Contract
    {
        public int contractID { get; set; }
        public string contractType { get; set; }
        public int employeeID { get; set; }
        public string workHours { get; set; }
        public string position { get; set; }
        public int departmentID { get; set; }
        public bool active { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string? reason { get; set; }

        // temporary Contract
        public Contract(string contractType, int employeeID, string workHours, string position, int departmentID, DateTime startDate, DateTime endDate) 
        {
            this.contractType = contractType;
            this.employeeID = employeeID;
            this.workHours = workHours;
            this.departmentID = departmentID;
            this.position = position;
            this.startDate = startDate;
            this.endDate = endDate;
            this.reason = null;
        }

        // Permanent Contract
        public Contract(string contractType, int employeeID, string workHours, string position, int departmentID, DateTime startDate)
        {
            this.contractType = contractType;
            this.employeeID = employeeID;
            this.workHours = workHours;
            this.departmentID = departmentID;
            this.position = position;
            this.startDate = startDate;
            this.endDate = null;
            this.reason = null;
        }



        //MapperForContract
        public Contract(int contractID, int employeeID)
        {
            this.contractID = contractID;
            this.employeeID = employeeID;
            this.contractType = contractType;
            this.workHours = workHours;
            this.position = position;
            this.active = active;
            this.departmentID = departmentID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.reason = reason;
        }

        public string Reason
        {
            get { return reason; }
            set 
            {
                if ( value != null )
                {
                    reason = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{contractID} - {contractType}";
        }

    }
}

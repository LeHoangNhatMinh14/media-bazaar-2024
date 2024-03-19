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
        public bool active { get; set; }
        public DateOnly startDate { get; set; }
        public DateOnly? endDate { get; set; }
        public string? reason { get; set; }

        // temporary Contract
        public Contract(int contractID, string contractType, int employeeID, string workHours, string position, DateOnly startDate, DateOnly endDate) 
        {
            this.contractID = contractID;
            this.contractType = contractType;
            this.employeeID = employeeID;
            this.workHours = workHours;
            this.position = position;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        // Permanent Contract
        public Contract(int contractID, string contractType, int employeeID, string workHours, string position, DateOnly startDate)
        {
            this.contractID = contractID;
            this.contractType = contractType;
            this.employeeID = employeeID;
            this.workHours = workHours;
            this.position = position;
            this.startDate = startDate;
        }



        //MapperForContract
        public Contract(int contractID, int employeeID)
        {
            this.contractType = contractType;
            this.workHours = workHours;
            this.position = position;
            this.active = active;
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

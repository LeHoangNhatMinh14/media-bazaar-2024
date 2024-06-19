using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Class
{
	public class RequestDaysOff
	{
		public int emloyeeID {  get; set; }
		public string? reason { get; set; }
		public DateTime startDate { get; set; }
		public DateTime endDate { get; set; }
		public bool approved { get; set; }
<<<<<<< HEAD

		public string? disaprovalReason {  get; set; }
		public string RequestInfo => $"{startDate.ToString("dd/MMM/yyyy")} - {endDate.ToString("dd/MMM/yyyy")}";
=======
		public string? disaprovalReason {  get; set; }
		public string? employeeEmail { get; set; }
		public string RequestInfo => $"{employeeEmail} : {startDate.ToString("dd/MMM/yyyy")} - {endDate.ToString("dd/MMM/yyyy")}";
>>>>>>> 7d8dd714f3afbedd212234116ef4b2f799b39aab

		public RequestDaysOff() { }

		public RequestDaysOff(int emloyeeID,string reason, DateTime startDate, DateTime endDate, bool approved, string? disaprovalReason)
		{
			this.emloyeeID = emloyeeID;
			this.reason = reason;
			this.startDate = startDate;
			this.endDate = endDate;
			this.approved = approved;
			this.disaprovalReason = disaprovalReason;
		}

		//For Mapper
		public RequestDaysOff(int emloyeeID)
		{
			this.emloyeeID = emloyeeID;
			this.reason = reason;
			this.startDate = startDate;
			this.endDate = endDate;
			this.approved = approved;
<<<<<<< HEAD
			this.disaprovalReason= disaprovalReason;
=======
			this.disaprovalReason = disaprovalReason;
>>>>>>> 7d8dd714f3afbedd212234116ef4b2f799b39aab
		}
	}
}

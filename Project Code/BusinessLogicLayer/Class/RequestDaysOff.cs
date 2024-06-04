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
=======
		public string? disapprovalReason {  get; set; }
		public string RequestInfo => $"{startDate.ToString("dd/MMM/yyyy")} - {endDate.ToString("dd/MMM/yyyy")}";
>>>>>>> 3b3f503defb90b36bd2fe23a3414f086b7c5870f

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
			this.disapprovalReason = disapprovalReason;
>>>>>>> 3b3f503defb90b36bd2fe23a3414f086b7c5870f
		}
	}
}

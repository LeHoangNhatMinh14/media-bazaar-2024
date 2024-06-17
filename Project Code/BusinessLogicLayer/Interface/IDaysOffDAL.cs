using BusinessLogicLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
	public interface IDaysOffDAL
	{
		public RequestDaysOff GetRequest(int employeeID);
		public void RequestDaysOff(RequestDaysOff daysOffRequest);
		public void AcceptOrDecline(int employeeID, bool approved, string disapprovalReason = null);
		List<RequestDaysOff> GetRequests();
		List<RequestDaysOff> GetDaysOffByEmployee(int employeeID);
        public void Undo(int employeeID);

		List<RequestDaysOff> GetRequestsByDepartment(string department);

    }
}

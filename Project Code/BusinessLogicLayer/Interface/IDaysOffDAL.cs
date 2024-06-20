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
		List<RequestDaysOff> GetRequests(bool approved);
		public void Undo(int employeeID);
        List<RequestDaysOff> GetDaysOffByEmployee(int employeeID);
        List<RequestDaysOff> GetRequestsByDepartment(string department);
        List<RequestDaysOff> GetRequests();
    }
}

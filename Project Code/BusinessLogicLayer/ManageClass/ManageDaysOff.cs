using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ManageClass
{
	public class ManageDaysOff
	{
		private IDaysOffDAL _daysOff;

		public ManageDaysOff(IDaysOffDAL daysOff)
		{
			_daysOff = daysOff;
		}

		public void AddDaysOffRequest(RequestDaysOff daysOff)
		{
			_daysOff.RequestDaysOff(daysOff);
		}
		public RequestDaysOff GetDaysOff(int employeeID) 
		{
			return _daysOff.GetRequest(employeeID);
		}

		public void AcceptOrDecline(int employeeID, bool approved, string disapprovalReason = null)
		{ 
			_daysOff.AcceptOrDecline(employeeID, approved,disapprovalReason);
		}

		public List<RequestDaysOff> GetDaysOff()
		{
			return _daysOff.GetRequests();
		}

		public void Undo(int employeeID)
		{
			_daysOff.Undo(employeeID);
		}
		public List<RequestDaysOff> GetRequestDaysOffs(int employeeID)
		{
			return _daysOff.GetDaysOffByEmployee(employeeID);
		}
	}
}

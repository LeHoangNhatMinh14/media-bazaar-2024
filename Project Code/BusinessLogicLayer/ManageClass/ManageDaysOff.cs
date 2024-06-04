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

<<<<<<< HEAD
		public RequestDaysOff GetDaysOff(int employeeID) 
		{
			return _daysOff.GetRequest(employeeID);
		}

		public void AcceptOrDecline()
=======
		public void AcceptOrDecline(int employeeID, bool approved, string disapprovalReason = null)
>>>>>>> 3b3f503defb90b36bd2fe23a3414f086b7c5870f
		{ 
			_daysOff.AcceptOrDecline(employeeID, approved,disapprovalReason);
		}

		public List<RequestDaysOff> GetDaysOff(bool approved)
		{
			return _daysOff.GetRequests(approved);
		}

		public void Undo(int employeeID)
		{
			_daysOff.Undo(employeeID);
		}
	}
}

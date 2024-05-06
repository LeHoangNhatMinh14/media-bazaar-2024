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
		public void RequestDaysOff(RequestDaysOff daysOffRequest);
		public void AcceptOrDecline();
	}
}

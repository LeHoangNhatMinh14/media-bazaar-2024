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
	}
}

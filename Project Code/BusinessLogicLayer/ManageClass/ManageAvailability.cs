using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ManageClass
{
	public class ManageAvailability
	{
		private IAvailabilityDAL availabilityDAL;

		public ManageAvailability(IAvailabilityDAL availabilityDAL)
		{
			this.availabilityDAL = availabilityDAL;
		}

		public void AddAvailability(Availability availability)
		{ 
			availabilityDAL.AddUsualAvailability(availability);
		}
	}
}

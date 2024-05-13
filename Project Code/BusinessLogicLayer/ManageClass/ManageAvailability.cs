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
		public List<Availability> availabilityList;

		public ManageAvailability(IAvailabilityDAL availabilityDAL)
		{
			this.availabilityDAL = availabilityDAL;
			availabilityList = new List<Availability>();
		}

		public void AddAvailability(Availability availability)
		{ 
			availabilityDAL.AddUsualAvailability(availability);
		}

		public bool IsEmployeeAvailableforShift(int employeeID,DateTime shiftDate)
		{
            Availability availability = availabilityDAL.GetAvailabilitiesofEmployee(employeeID);

            if (availability == null)
            {
                return false;
            }
            DayOfWeek shiftDayOfWeek = shiftDate.DayOfWeek;

            switch (shiftDayOfWeek)
            {
                case DayOfWeek.Monday:
                    return availability.monday;
                case DayOfWeek.Tuesday:
                    return availability.tuesday;
                case DayOfWeek.Wednesday:
                    return availability.wednesday;
                case DayOfWeek.Thursday:
                    return availability.thursday;
                case DayOfWeek.Friday:
                    return availability.friday;
                case DayOfWeek.Saturday:
                    return availability.saturday;
                case DayOfWeek.Sunday:
                    return availability.sunday;
                default:
                    return false;
            }
        }
	}
}

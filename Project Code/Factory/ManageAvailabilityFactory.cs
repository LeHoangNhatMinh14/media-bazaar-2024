using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using DAL;

namespace Factory
{
	public class ManageAvailabilityFactory
	{
		public static ManageAvailability manageAvailability;

		public static ManageAvailability Create()
		{	
			if(manageAvailability == default)
			{
				manageAvailability = new(new AvailabilityRepo());
			}
			return manageAvailability;
		}
	}
}

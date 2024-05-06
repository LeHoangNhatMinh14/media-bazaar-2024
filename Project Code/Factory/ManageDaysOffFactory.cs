using BusinessLogicLayer.Class;
using BusinessLogicLayer.ManageClass;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
	public class ManageDaysOffFactory
	{
		public static ManageDaysOff manageDaysOff;

		public static ManageDaysOff Create()
		{
			if (manageDaysOff == default) 
			{
				manageDaysOff = new(new DaysOffRepo());
			}
			return manageDaysOff;
		}
	}
}

using BusinessLogicLayer.ManageClass;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
<<<<<<< HEAD
	public class ManageContractFactory
	{
		public static ManageContract manageContract;
		public static ManageContract Create()
		{
			if (manageContract == default)
			{
				manageContract = new(new ContractRepo());
			}
			return manageContract;
		}
	}
=======
    public class ManageContractFactory
    {
        public static ManageContract manageContract;

        public static ManageContract Create()
        {
            if (manageContract == default)
            {
                manageContract = new (new ContractRepo());
            }
            return manageContract;
        }
    }
>>>>>>> 0810f432fcf01d6948f7c3a4a2a88fb958219639
}

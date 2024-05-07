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
>>>>>>> db69de2e9d4107cdcc8b28012bc69f78f807ff03
}

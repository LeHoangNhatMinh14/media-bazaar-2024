using BusinessLogicLayer.ManageClass;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
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
}

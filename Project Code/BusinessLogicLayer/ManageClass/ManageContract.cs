using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ManageClass
{
    public class ManageContract
    {
        private List<Class.Contract> contracts;
        private IContractsDAL contractsDAL;

        public ManageContract(IContractsDAL contract) 
        {
            contractsDAL = contract;
            contracts = new List<Class.Contract>();
        }

        public void AddContract(Contract contract)
        {
            contractsDAL.AddContract(contract);
        }
        
        public Contract GetContract(int employeeID)
        {
            return contractsDAL.GetContract(employeeID);
        }


    }
}

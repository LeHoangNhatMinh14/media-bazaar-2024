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
        private List<Contract> contracts;
        private IContractsDAL contractsDAL;

<<<<<<< HEAD
        public ManageContract( IContractsDAL contractsDAL) 
        {
            contracts = new List<Contract>();
            this.contractsDAL = contractsDAL;
=======
        public ManageContract(IContractsDAL contract) 
        {
            contractsDAL = contract;
            contracts = new List<Class.Contract>();
>>>>>>> 0810f432fcf01d6948f7c3a4a2a88fb958219639
        }

        public void AddContract(Contract contract)
        {
            contractsDAL.AddContract(contract);
        }
        
        public Contract GetContract(int employeeID)
        {
            Contract contract = contractsDAL.GetContract(employeeID);
            return contract;
        }


    }
}

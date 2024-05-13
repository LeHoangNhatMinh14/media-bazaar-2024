using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;

namespace BusinessLogicLayer.ManageClass
{
	public class ManageContract
	{
		private List<Contract> contracts;
		private IContractsDAL contractsDAL;

<<<<<<< HEAD
		public ManageContract(IContractsDAL contractsDAL)
		{
			contracts = new List<Contract>();
			this.contractsDAL = contractsDAL;
		}
=======
        public ManageContract(IContractsDAL contract) 
        {
            contractsDAL = contract;
            contracts = new List<Class.Contract>();
        }
>>>>>>> 15ef613ac76ac61e18b32e8dffbeeccfd9850716

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

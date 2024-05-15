using BusinessLogicLayer.Class;
using BusinessLogicLayer.Interface;

namespace BusinessLogicLayer.ManageClass
{
	public class ManageContract
	{
		private List<Contract> contracts;
		private IContractsDAL contractsDAL;

		public ManageContract(IContractsDAL contractsDAL)
		{
			contracts = new List<Contract>();
			this.contractsDAL = contractsDAL;
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

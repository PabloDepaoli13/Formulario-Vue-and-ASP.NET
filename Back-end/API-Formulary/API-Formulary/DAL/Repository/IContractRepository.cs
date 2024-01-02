using API_Formulary.Models;

namespace API_Formulary.DAL.Repository
{
	public interface IContractRepository
	{
		public Task<Contract> GetContractById(int id);
	}
}

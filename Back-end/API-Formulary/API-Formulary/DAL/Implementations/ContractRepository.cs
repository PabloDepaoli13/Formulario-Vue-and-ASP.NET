using API_Formulary.DAL.DataContext;
using API_Formulary.DAL.Repository;
using API_Formulary.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Formulary.DAL.Implementations
{
	public class ContractRepository : IContractRepository
	{
		private readonly AplicationDbContext _context;
		public ContractRepository(AplicationDbContext context)
		{
			_context = context;
		}
		public async Task<Contract> GetContractById(int id)
		{
			var query = await _context.Contracts
				.Include(e => e.Requests)
				.ThenInclude(e => e.Item)
				.FirstOrDefaultAsync(e => e.Id == id);

			return query;
		}
	}
}

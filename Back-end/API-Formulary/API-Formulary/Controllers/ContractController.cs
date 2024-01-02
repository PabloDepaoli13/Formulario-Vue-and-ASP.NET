using API_Formulary.DAL.Repository;
using API_Formulary.DTO;
using API_Formulary.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Formulary.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContractController : ControllerBase
	{
		private readonly IContractRepository _contractRepository;
		private readonly IMapper _mapper;
        public ContractController(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
			_mapper = mapper;
        }

        [HttpGet("{id}")]

		public async Task<ActionResult<ContractDTO>> GetContractById(int id) 
		{

			var contract = await _contractRepository.GetContractById(id);
			if (contract == null)
				return NotFound();

			var contractDto = _mapper.Map<ContractDTO>(contract);
			return Ok(contractDto);

		}
	}
}

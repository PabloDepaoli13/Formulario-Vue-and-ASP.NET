using API_Formulary.DTO;
using API_Formulary.Models;
using AutoMapper;

namespace API_Formulary.Utilities
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Contract, ContractDTO>()
				.ForMember(d => d.FechaAlta,
					opt => opt.MapFrom(o => o.FechaAlta.ToString("dd/MM/yyyy")))
				.ForMember(d => d.FechaEntrega,
					opt => opt.MapFrom(o => o.FechaEntrega.ToString("dd/MM/yyyy")));

			CreateMap<Request, RequestDTO>()
				.ForMember(d => d.CantidadEgresados, o => o.MapFrom(src => src.Contract.CantidadEgresados))
				.ForMember(d => d.Articulo, o => o.MapFrom(src => src.Item.Nombre))
				.ForMember(d => d.PrecioUnitario, o => o.MapFrom(src => src.Item.Precio));


		}
	}
}

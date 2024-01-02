namespace API_Formulary.DTO
{
	public class ContractDTO
	{
		public int Id { get; set; }

		public string? CourseCode { get; set; }

		public string? FechaAlta { get; set; }

		public string? ColegioNivel { get; set; }

		public string? ColegioNombre { get; set; }

		public string? ColegioCurso { get; set; }

		public string? ColegioLocalidad { get; set; }

		public virtual HashSet<RequestDTO> Requests { get; set; } = new HashSet<RequestDTO>();

		public int? CantidadEgresados { get; set; }

		public decimal? Total { get; set; }

		public string? FechaEntrega { get; set; }
	}
}

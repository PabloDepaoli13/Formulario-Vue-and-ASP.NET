using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Formulary.Models
{
	public class Contract
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string? CourseCode { get; set; }

		public DateTime FechaAlta { get; set; }

		public bool? Estado { get; set; }

		public int? CantidadEgresados { get; set; }

		public DateTime FechaEntrega { get; set; }

		public string? MedioEntrega { get; set; }

		public int? Vendedor { get; set; }

		public string? ColegioNivel { get; set; }

		public string? ColegioNombre { get; set; }

		public string? ColegioCurso { get; set; }

		public string? ColegioLocalidad { get; set; }

		public int? Comision { get; set; }

		public double? Total { get; set; }

		public virtual HashSet<Request>  Requests { get; set; } = new HashSet<Request>();
	}
}

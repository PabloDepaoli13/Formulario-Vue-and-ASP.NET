using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Formulary.Models
{
	public class Item
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string? Nombre { get; set; }

		public double? Precio { get; set; }

		public virtual HashSet<Request> Requests { get; set; } = new HashSet<Request>();
	}
}

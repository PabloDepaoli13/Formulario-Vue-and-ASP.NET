using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Formulary.Models
{
	public class Request
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[ForeignKey("ContractId")]
		public int? ContractId { get; set; }
		[ForeignKey("ItemId")]
		public int? ItemId { get; set; }

		public DateTime? CreateDate { get; set; }

		public DateTime? UpdateDate { get; set; }

		public bool? Enabled { get; set; }

		public bool? Deleted { get; set; }

		public string? CreatedBy { get; set; }

		public virtual Contract? Contract { get; set; } = null!;

		public virtual Item? Item { get; set; } = null!;
	}
}

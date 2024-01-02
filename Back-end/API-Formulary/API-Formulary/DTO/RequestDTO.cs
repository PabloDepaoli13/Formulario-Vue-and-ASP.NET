namespace API_Formulary.DTO
{
	public class RequestDTO
	{
		//CantidadEgresados => Contrato.CantidadEgresados
		public int? CantidadEgresados { get; set; }

		//Articulo => Item.Nombre
		public string? Articulo { get; set; }
		//PrecioUnitario => Item.Precio
		public double? PrecioUnitario { get; set; }

		public double? TotalArticulo => CantidadEgresados * PrecioUnitario;
	}
}

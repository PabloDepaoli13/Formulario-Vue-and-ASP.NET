using API_Formulary.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Formulary.DAL.DataContext
{
	public class AplicationDbContext : DbContext
	{
		public AplicationDbContext(DbContextOptions options) : base(options)
		{ }

		public DbSet<Contract> Contracts { get; set; }

		public DbSet<Item> Items { get; set; }

		public DbSet<Request> Requests { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder
				.UseCollation("utf8mb4_0900_ai_ci")
				.HasCharSet("utf8mb4");

			modelBuilder.Entity<Contract>(entity =>
			{
				entity.ToTable("contract");

				entity.Property(e => e.ColegioLocalidad).HasMaxLength(255);
				entity.Property(e => e.ColegioNivel).HasMaxLength(255);
				entity.Property(e => e.ColegioNombre).HasMaxLength(255);
				entity.Property(e => e.CourseCode).HasMaxLength(255);
				entity.Property(e => e.FechaAlta).HasColumnType("datetime");
				entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
				entity.Property(e => e.MedioEntrega).HasMaxLength(255);
				entity.Property(e => e.Total).HasPrecision(6, 2);
			});

			modelBuilder.Entity<Item>(entity =>
			{
				entity.ToTable("item");

				entity.Property(e => e.Nombre).HasMaxLength(255);
				entity.Property(e => e.Precio).HasPrecision(6, 2);
			});

			modelBuilder.Entity<Request>(entity =>
			{

				entity.ToTable("request");

				entity.HasIndex(e => e.ContractId, "ContractId");

				entity.HasIndex(e => e.ItemId, "ItemId");

				entity.Property(e => e.CreateDate).HasColumnType("datetime");
				entity.Property(e => e.CreatedBy).HasMaxLength(255);
				entity.Property(e => e.UpdateDate).HasColumnType("datetime");

			});

		}

		
	}
}
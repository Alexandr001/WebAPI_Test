using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer;

public class StoreContext : DbContext
{
	public DbSet<CategoryModel> Category { get; set; } = null!;
	public DbSet<ProductModel> Product { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TestOxigenDb;Trusted_Connection=True; TrustServerCertificate=True;");
	}
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<CategoryModel>().ToTable("Categories");
		modelBuilder.Entity<ProductModel>().ToTable("Products");
	}
}
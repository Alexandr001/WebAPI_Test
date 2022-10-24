using AdminPanelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanelApi.DataAccessLayer.EntityFramework;

public class StoreContext : DbContext
{
	private readonly string? _connectionString;

	public StoreContext(IConfiguration configuration) => 
			_connectionString = configuration.GetConnectionString("SqlConnection");

	public DbSet<CategoryModel> Category { get; set; } = null!;
	public DbSet<ProductModel> Product { get; set; } = null!;

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
			optionsBuilder.UseSqlServer(_connectionString);

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<CategoryModel>().ToTable("Categories");
		modelBuilder.Entity<ProductModel>().ToTable("Products");
	}
}
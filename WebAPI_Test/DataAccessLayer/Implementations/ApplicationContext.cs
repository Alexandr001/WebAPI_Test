using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebAPI_Test.Models;

namespace WebAPI_Test.DataAccessLayer.Implementations;

public class ApplicationContext : DbContext
{
	private const string ADDRESS = "SmartweyTestDB.mssql.somee.com";
	private const string NAME = "SmartweyTestDB";
	private const string LOGIN = "Alexandr001_SQLLogin_1";
	private const string PASSWORD = "ppd8bthp76";
	
	private const string CONNECTION = $"Data Source={ADDRESS}; " +
	                                  $"Initial Catalog={NAME}; " +
	                                  $"User id={LOGIN}; " +
	                                  $"Password={PASSWORD}; " +
	                                  "TrustServerCertificate=True";
        
	public DbSet<ProductModel> ProductModels { get; set; } = null!;
	public DbSet<ImageModel> ImageModels { get; set; } = null!;
 
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(CONNECTION);
	}
	// public static SqlConnection CreateConnection()
	// {
	// 	return new SqlConnection(CONNECTION);
	// }
}
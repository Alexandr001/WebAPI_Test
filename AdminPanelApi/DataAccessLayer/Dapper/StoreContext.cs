using System.Data;
using Microsoft.Data.SqlClient;

namespace AdminPanelApi.DataAccessLayer.Dapper;

public class StoreContext
{
	private readonly string? _connectionString;
	
	public StoreContext(IConfiguration configuration)
	{
		_connectionString = configuration.GetConnectionString("SqlConnection");
	}
	public IDbConnection CreateConnection()
		=> new SqlConnection(_connectionString);
}
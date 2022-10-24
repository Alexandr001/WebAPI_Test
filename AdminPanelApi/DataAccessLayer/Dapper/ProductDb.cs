using System.Data;
using AdminPanelApi.DataAccessLayer.Interfaces;
using AdminPanelApi.Models;
using Dapper;

namespace AdminPanelApi.DataAccessLayer.Dapper;

public class ProductDb : IProductDb
{
	private readonly StoreContext _context;
	public ProductDb(StoreContext context) => _context = context;

	public async Task<List<ProductModel>> GetAllProducts()
	{
		string query = "SELECT * FROM Products";
		using (IDbConnection connect = _context.CreateConnection()) {
			var productModels = await connect.QueryAsync<ProductModel>(query);
			return productModels.ToList();
		}
	}

	public async Task<ProductModel?> GetProduct(int id)
	{
		string query = "SELECT * FROM Products WHERE Id = @Id";
		using (IDbConnection connect = _context.CreateConnection()) {
			ProductModel model = await connect.QuerySingleOrDefaultAsync<ProductModel>(query, new { id });
			return model;
		}
	}

	public async Task AddProduct(ProductModel model)
	{
		string query = "INSERT INTO Products VALUES " + 
		               "(Name = @Name, " + 
		               "Description = @Description, " +
		               "Price = @Price, " +
		               "Image = @Image, " +
		               "CategoryId = @CategoryId)";
		using (IDbConnection connect = _context.CreateConnection()) {
			await connect.ExecuteAsync(query, model);
		}
	}

	public async Task EditProduct(ProductModel model)
	{
		string query = "UPDATE Products SET " + 
		               "Name = @Name, " + 
		               "Description = @Description, " +
		               "Price = @Price, " +
		               "Image = @Image, " +
		               "CategoryId = @CategoryId WHERE Id = @Id";
		using (IDbConnection connect = _context.CreateConnection()) {
			await connect.ExecuteAsync(query, model);
		}
	}

	public async Task DeleteProduct(int id)
	{
		string query = "DELETE FROM Products WHERE Id = @Id";
		using (IDbConnection connect = _context.CreateConnection()) {
			await connect.ExecuteAsync(query, new {id});
		}
	}
}
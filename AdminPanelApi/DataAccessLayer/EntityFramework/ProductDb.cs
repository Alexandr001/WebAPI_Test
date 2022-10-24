using AdminPanelApi.DataAccessLayer.Interfaces;
using AdminPanelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanelApi.DataAccessLayer.EntityFramework;

public class ProductDb : IProductDb
{
	private readonly ICategoryDb _categoryDb;
	private StoreContext _context;

	public ProductDb(ICategoryDb categoryDb, StoreContext context)
	{
		_categoryDb = categoryDb;
		_context = context;
	}

	public async Task<List<ProductModel>> GetAllProducts()
	{
		await using (_context) {
			return await _context.Product.ToListAsync();
		}
	}

	public Task<ProductModel?> GetProduct(int id)
	{
		throw new NotImplementedException();
	}

	public async Task AddProduct(ProductModel model)
	{
		await using (_context) {
			await _context.Product.AddAsync(model);
			await _context.SaveChangesAsync();
		}
	}

	public Task EditProduct(ProductModel model)
	{
		throw new NotImplementedException();
	}

	public Task DeleteProduct(int id)
	{
		throw new NotImplementedException();
	}
}
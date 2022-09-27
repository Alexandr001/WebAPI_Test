using AdminPanel.DataAccessLayer.Interfaces;
using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer;

public class ProductDb : IProductDb
{
	private readonly StoreContext _context;

	public ProductDb(StoreContext context)
	{
		_context = context;
	}

	public async Task<List<ProductModel>> GetAllProducts()
	{
		return await _context.Product.ToListAsync();
	}

	public Task AddProduct(ProductModel categoryModel)
	{
		throw new NotImplementedException();
	}

	public Task EditProduct(ProductModel categoryModel)
	{
		throw new NotImplementedException();
	}

	public Task DeleteProduct(int id)
	{
		throw new NotImplementedException();
	}
}
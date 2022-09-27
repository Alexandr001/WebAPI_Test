using AdminPanel.DataAccessLayer.Interfaces;
using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer;

public class ProductDb : IProductDb
{
	private readonly ICategoryDb _categoryDb;

	public ProductDb(ICategoryDb categoryDb)
	{
		_categoryDb = categoryDb;
	}

	public async Task<List<ProductModel>> GetAllProducts()
	{
		await using (StoreContext context = new()) {
			return await context.Product.ToListAsync();
		}
	}

	public async Task AddProduct(ProductModel productModel)
	{
		if (productModel.CategoryId != null) {
			productModel.Category = await _categoryDb.GetCategory(productModel.CategoryId.Value);
		}
		await using (StoreContext context = new()) {
			await context.Product.AddAsync(productModel);
			await context.SaveChangesAsync();
		}
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
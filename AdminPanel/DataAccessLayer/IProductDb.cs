using AdminPanel.Models;

namespace AdminPanel.DataAccessLayer;

public interface IProductDb
{
	Task<List<CategoryModel>> GetAllProducts();
	Task AddProduct(CategoryModel categoryModel);
	Task EditProduct(CategoryModel categoryModel);
	Task DeleteProduct(Guid id);
}

public class ProductDb : IProductDb
{
	public Task<List<CategoryModel>> GetAllProducts()
	{
		throw new NotImplementedException();
	}

	public Task AddProduct(CategoryModel categoryModel)
	{
		throw new NotImplementedException();
	}

	public Task EditProduct(CategoryModel categoryModel)
	{
		throw new NotImplementedException();
	}

	public Task DeleteProduct(Guid id)
	{
		throw new NotImplementedException();
	}
}
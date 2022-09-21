using WebAPI_Test.BusinessLayer.Interfaces;
using WebAPI_Test.DataAccessLayer.Implementations;

namespace WebAPI_Test.BusinessLayer.Implementations;

public class ProductBl<TModel> : IProductBl<TModel>
{
	private readonly ProductDb<TModel> _productDb;
	public ProductBl(ProductDb<TModel> productDb) => _productDb = productDb;

	public async Task<List<TModel>> GetAllProducts()
	{
		return await _productDb.GetAllProducts();
	}

	public async Task<List<TModel>> GetProductByName(string name)
	{
		return await _productDb.GetProductByName(name);
	}

	public async Task<TModel> GetProductById(Guid id)
	{
		return await _productDb.GetProductsById(id);
	}
}
using WebAPI_Test.DataAccessLayer.Interfaces;

namespace WebAPI_Test.DataAccessLayer.Implementations;

public class ProductDb<TModel> : IProductDb<TModel>
{
	async public Task<List<TModel>> GetAllProducts()
	{
		throw new NotImplementedException();
	}

	async public Task<List<TModel>> GetProductByName(string name)
	{
		throw new NotImplementedException();
	}

	async public Task<TModel> GetProductsById(Guid id)
	{
		throw new NotImplementedException();
	}
}
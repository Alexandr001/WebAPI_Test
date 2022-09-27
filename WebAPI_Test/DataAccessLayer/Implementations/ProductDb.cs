using WebAPI_Test.DataAccessLayer.Interfaces;
using WebAPI_Test.Models;

namespace WebAPI_Test.DataAccessLayer.Implementations;

public class ProductDb : IProductDb
{
	async public Task<List<ProductModel>> GetAllProducts()
	{
		throw new NotImplementedException();
	}

	async public Task<List<ProductModel>> GetProductByName(string name)
	{
		throw new NotImplementedException();
	}

	async public Task<ProductModel> GetProductsById(Guid id)
	{
		throw new NotImplementedException();
	}
}
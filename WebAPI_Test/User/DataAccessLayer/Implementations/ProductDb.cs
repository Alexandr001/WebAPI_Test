using WebAPI_Test.Models;
using WebAPI_Test.User.DataAccessLayer.Interfaces;

namespace WebAPI_Test.User.DataAccessLayer.Implementations;

public class ProductDb : IProductDb
{
	public List<ProductModel> GetAllProducts()
	{
		throw new NotImplementedException();
	}

	public List<ProductModel> GetProductsById(Guid id)
	{
		throw new NotImplementedException();
	}

	public ProductModel GetProductByName(string name)
	{
		throw new NotImplementedException();
	}
}
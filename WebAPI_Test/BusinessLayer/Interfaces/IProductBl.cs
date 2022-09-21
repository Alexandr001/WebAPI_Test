using WebAPI_Test.Models;
using WebAPI_Test.User.DataAccessLayer.Implementations;

namespace WebAPI_Test.BusinessLayer.Interfaces;

public interface IProductBl
{
	public List<ProductModel> GetAllProducts();
	public List<ProductModel> GetProductByName(string name);
	public ProductModel GetProductById(Guid id);
}

public class ProductBl : IProductBl
{
	private readonly ProductDb _productDb;
	public ProductBl(ProductDb productDb) => _productDb = productDb;

	public List<ProductModel> GetAllProducts()
	{
		throw new NotImplementedException();
	}

	public List<ProductModel> GetProductByName(string name)
	{
		throw new NotImplementedException();
	}

	public ProductModel GetProductById(Guid id)
	{
		throw new NotImplementedException();
	}
}
using WebAPI_Test.BusinessLayer.Interfaces;
using WebAPI_Test.DataAccessLayer.Interfaces;
using WebAPI_Test.Models;

namespace WebAPI_Test.BusinessLayer.Implementations;

public class ProductBl : IProductBl
{
	private readonly IProductDb _productDb;
	public ProductBl(IProductDb productDb) => _productDb = productDb;

	public async Task<List<ProductModel>> GetAllProducts(Filtration? filtration)
	{
		return await _productDb.GetAllProducts(filtration);
	}
	public async Task<List<ProductModel>> GetProductByName(string name)
	{
		return await _productDb.GetProductByName(name);
	}
	public async Task<ProductModel> GetProductById(int id)
	{
		return await _productDb.GetProductsById(id);
	}
}

public enum Filtration
{
	NO_FILTER,
	ORDER_BY_NAME,
	ORDER_BY_PRICE
}
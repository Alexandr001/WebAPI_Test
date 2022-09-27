using WebAPI_Test.BusinessLayer.Interfaces;
using WebAPI_Test.DataAccessLayer.Implementations;
using WebAPI_Test.DataAccessLayer.Interfaces;
using WebAPI_Test.Models;

namespace WebAPI_Test.BusinessLayer.Implementations;

public class ProductBl : IProductBl
{
	private readonly IProductDb _productDb;
	public ProductBl(IProductDb productDb) => _productDb = productDb;

	public async Task<List<ProductModel>> GetAllProducts()
	{
		return await _productDb.GetAllProducts();
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
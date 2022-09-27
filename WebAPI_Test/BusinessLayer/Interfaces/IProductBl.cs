using WebAPI_Test.Models;

namespace WebAPI_Test.BusinessLayer.Interfaces;

public interface IProductBl
{
	public Task<List<ProductModel>> GetAllProducts();
	public Task<List<ProductModel>> GetProductByName(string name);
	public Task<ProductModel> GetProductById(int id);
}
using WebAPI_Test.Models;

namespace WebAPI_Test.DataAccessLayer.Interfaces;

public interface IProductDb
{
	Task<List<ProductModel>> GetAllProducts();
	Task<List<ProductModel>> GetProductByName(string name);
	Task<ProductModel> GetProductsById(int id);
}
using WebAPI_Test.Models;

namespace WebAPI_Test.DataAccessLayer.Interfaces;

public interface IProductDb<TModel>
{
	Task<List<TModel>> GetAllProducts();
	Task<List<TModel>> GetProductByName(string name);
	Task<TModel> GetProductsById(Guid id);
}
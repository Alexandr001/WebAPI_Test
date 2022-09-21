using WebAPI_Test.Models;

namespace WebAPI_Test.BusinessLayer.Interfaces;

public interface IProductBl<TModel>
{
	public Task<List<TModel>> GetAllProducts();
	public Task<List<TModel>> GetProductByName(string name);
	public Task<TModel> GetProductById(Guid id);
}
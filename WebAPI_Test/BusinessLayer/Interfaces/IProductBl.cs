using WebAPI_Test.BusinessLayer.Implementations;
using WebAPI_Test.Models;

namespace WebAPI_Test.BusinessLayer.Interfaces;

public interface IProductBl
{
	public Task<List<ProductModel>> GetAllProducts(Filtration? filtration);
	public Task<List<ProductModel>> GetProductByName(string name);
	public Task<ProductModel> GetProductById(int id);
}
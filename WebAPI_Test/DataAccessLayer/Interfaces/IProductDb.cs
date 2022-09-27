using WebAPI_Test.BusinessLayer.Implementations;
using WebAPI_Test.Models;

namespace WebAPI_Test.DataAccessLayer.Interfaces;

public interface IProductDb
{
	Task<List<ProductModel>> GetAllProducts(Filtration? filtration);
	Task<List<ProductModel>> GetProductByName(string name);
	Task<ProductModel> GetProductsById(int id);
}
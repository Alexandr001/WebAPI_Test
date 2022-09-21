using WebAPI_Test.Models;

namespace WebAPI_Test.User.DataAccessLayer.Interfaces;

public interface IProductDb
{
	List<ProductModel> GetAllProducts();
	List<ProductModel> GetProductsById(Guid id);
	ProductModel GetProductByName(string name);
}
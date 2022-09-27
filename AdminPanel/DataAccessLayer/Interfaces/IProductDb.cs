using AdminPanel.Models;

namespace AdminPanel.DataAccessLayer.Interfaces;

public interface IProductDb
{
	Task<List<ProductModel>> GetAllProducts();
	Task AddProduct(ProductModel categoryModel);
	Task EditProduct(ProductModel categoryModel);
	Task DeleteProduct(int id);
}
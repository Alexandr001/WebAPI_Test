using AdminPanelApi.Models;

namespace AdminPanelApi.DataAccessLayer.Interfaces;

public interface IProductDb
{
	Task<List<ProductModel>> GetAllProducts();
	Task<ProductModel?> GetProduct(int id);
	Task AddProduct(ProductModel model);
	Task EditProduct(ProductModel model);
	Task DeleteProduct(int id);
}
using AdminPanel.Models;

namespace AdminPanel.DataAccessLayer.Interfaces;

public interface ICategoryDb
{
	Task<List<CategoryModel>> GetAllCategories();
	Task AddCategory(CategoryModel categoryModel);
	Task EditCategory(CategoryModel categoryModel);
	Task DeleteCategory(int id);
	Task<CategoryModel?> GetCategory(int id);
}
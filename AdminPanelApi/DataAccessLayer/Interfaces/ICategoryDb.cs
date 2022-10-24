using AdminPanelApi.Models;

namespace AdminPanelApi.DataAccessLayer.Interfaces;

public interface ICategoryDb
{
	Task<List<CategoryModel>> GetAllCategories();
	Task<CategoryModel?> GetCategoryById(int id);
	Task AddCategory(CategoryModel categoryModel);
	Task EditCategory(CategoryModel categoryModel);
	Task DeleteCategory(int id);
}
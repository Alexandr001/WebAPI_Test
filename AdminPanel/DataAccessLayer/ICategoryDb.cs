using AdminPanel.Models;

namespace AdminPanel.DataAccessLayer;

public interface ICategoryDb
{
	Task<List<CategoryModel>> GetAllCategories();
	Task AddCategory(CategoryModel categoryModel);
	Task EditCategory(CategoryModel categoryModel);
	Task DeleteCategory(Guid id);
}

public class CategoryDb : ICategoryDb
{
	public Task<List<CategoryModel>> GetAllCategories()
	{
		throw new NotImplementedException();
	}

	public Task AddCategory(CategoryModel categoryModel)
	{
		throw new NotImplementedException();
	}

	public Task EditCategory(CategoryModel categoryModel)
	{
		throw new NotImplementedException();
	}

	public Task DeleteCategory(Guid id)
	{
		throw new NotImplementedException();
	}
}
using AdminPanel.DataAccessLayer.Interfaces;
using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.DataAccessLayer;

public class CategoryDb : ICategoryDb
{

	public async Task<List<CategoryModel>> GetAllCategories()
	{
		await using (StoreContext context = new()) {
			return await context.Category.ToListAsync();
		}
	}

	public async Task AddCategory(CategoryModel categoryModel)
	{
		await using (StoreContext context = new()) {
			await context.Category.AddAsync(categoryModel);
			await context.SaveChangesAsync();
		}
	}

	public Task EditCategory(CategoryModel categoryModel)
	{
		throw new NotImplementedException();
	}

	public Task DeleteCategory(int id)
	{
		throw new NotImplementedException();
	}
}
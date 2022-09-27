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

	public async Task EditCategory(CategoryModel model)
	{
		await using (StoreContext context = new()) {
			context.Category.Update(model);
			await context.SaveChangesAsync();
		}
	}

	public async Task DeleteCategory(int id)
	{
		await using (StoreContext context = new()) {
			CategoryModel? model = await context.Category.FindAsync(id);
			if (model != null) {
				context.Category.Remove(model);
				await context.SaveChangesAsync();
			}
		}
	}

	public async Task<CategoryModel?> GetCategory(int id)
	{
		await using (StoreContext context = new()) {
			return await context.Category.FindAsync(id);
		}
	}
}
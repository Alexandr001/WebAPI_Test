using AdminPanelApi.DataAccessLayer.Interfaces;
using AdminPanelApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminPanelApi.DataAccessLayer.EntityFramework;

public class CategoryDb : ICategoryDb
{
	private readonly StoreContext _context;

	public CategoryDb(StoreContext context)
	{
		_context = context;
	}

	public async Task<List<CategoryModel>> GetAllCategories()
	{
		await using (_context) {
			return await _context.Category.ToListAsync();
		}
	}

	public async Task AddCategory(CategoryModel categoryModel)
	{
		await using (_context) {
			await _context.Category.AddAsync(categoryModel);
			await _context.SaveChangesAsync();
		}
	}

	public async Task EditCategory(CategoryModel model)
	{
		await using (_context) {
			_context.Category.Update(model);
			await _context.SaveChangesAsync();
		}
	}

	public async Task DeleteCategory(int id)
	{
		await using (_context) {
			CategoryModel? model = await _context.Category.FindAsync(id);
			if (model != null) {
				_context.Category.Remove(model);
				await _context.SaveChangesAsync();
			}
		}
	}

	public async Task<CategoryModel?> GetCategoryById(int id)
	{
		await using (_context) {
			return await _context.Category.FindAsync(id);
		}
	}
}
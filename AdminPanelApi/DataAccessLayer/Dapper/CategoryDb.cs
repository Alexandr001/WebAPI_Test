using System.Data;
using AdminPanelApi.DataAccessLayer.Interfaces;
using AdminPanelApi.Models;

namespace AdminPanelApi.DataAccessLayer.Dapper;

public class CategoryDb : ICategoryDb
{
	private readonly StoreContext _context;

	public CategoryDb(StoreContext context)
	{
		_context = context;
	}
	public async Task<List<CategoryModel>> GetAllCategories()
	{
		using (IDbConnection connect = _context.CreateConnection()) {
			
		}
		
	}

	public async Task<CategoryModel?> GetCategoryById(int id)
	{
		using (IDbConnection connect = _context.CreateConnection()) {
			
		}
		
	}

	public async Task AddCategory(CategoryModel categoryModel)
	{
		using (IDbConnection connect = _context.CreateConnection()) {
			
		}
		
	}

	public async Task EditCategory(CategoryModel categoryModel)
	{
		using (IDbConnection connect = _context.CreateConnection()) {
			
		}
		
	}

	public async Task DeleteCategory(int id)
	{
		using (IDbConnection connect = _context.CreateConnection()) {
			
		}
		
	}
}
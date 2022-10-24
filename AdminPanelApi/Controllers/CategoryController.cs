using AdminPanelApi.DataAccessLayer.Interfaces;
using AdminPanelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanelApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : Controller
{
	private readonly ICategoryDb _categoryDb;

	public CategoryController(ICategoryDb categoryDb)
	{
		_categoryDb = categoryDb;
	}
	
	[HttpGet]
	public async Task<List<CategoryModel>> GetAllCategories() => 
			await _categoryDb.GetAllCategories();
	
	[HttpGet("{id}")]
	public async Task<CategoryModel?> GetCategoryById(int id) => 
			await _categoryDb.GetCategoryById(id);

	[HttpPost]
	public async Task AddCategory(CategoryModel model) => 
			await _categoryDb.AddCategory(model);

	[HttpPut]
	public async Task EditCategory(CategoryModel model) => 
			await _categoryDb.EditCategory(model);

	[HttpDelete("{id}")]
	public async Task DeleteCategory(int id) => 
			await _categoryDb.DeleteCategory(id);
}
using AdminPanel.DataAccessLayer.Interfaces;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers;

public class CategoryController : HomeController
{
	private readonly ICategoryDb _categoryDb;

	public CategoryController(ICategoryDb categoryDb)
	{
		_categoryDb = categoryDb;
	}

	[HttpGet]
	public async Task<IActionResult> Category() => View(await _categoryDb.GetAllCategories());

	[HttpGet]
	public IActionResult Create() => View();

	[HttpGet]
	public async Task<IActionResult> Edit(int id) => View(await _categoryDb.GetCategory(id));

	[HttpPost()]
	public async Task<IActionResult> AddCategory(CategoryModel model)
	{
		await _categoryDb.AddCategory(model);
		return Ok();
	}

	[HttpPost()]
	public async Task<IActionResult> EditCategory(CategoryModel model)
	{
		await _categoryDb.EditCategory(model);
		return Ok();
	}

	[HttpPost("Delete")]
	public async Task<IActionResult> DeleteCategory(int id)
	{
		await _categoryDb.DeleteCategory(id);
		return Ok();
	}
	
}
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

	[HttpPost("/Category/Create")]
	public async Task<IActionResult> AddCategory(CategoryModel model)
	{
		await _categoryDb.AddCategory(model);
		return View("Create");
	}
}
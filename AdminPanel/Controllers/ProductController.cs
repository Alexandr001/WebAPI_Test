using AdminPanel.DataAccessLayer.Interfaces;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers;

public class ProductController : HomeController
{
	private readonly IProductDb _productDb;
	public ProductController(IProductDb productDb)
	{
		_productDb = productDb;
	}
	[HttpGet]
	public async Task<IActionResult> Product() => View(await _productDb.GetAllProducts());
	public IActionResult Create() => View();

	[HttpPost]
	public IActionResult AddProduct(ProductModel model)
	{
		_productDb.AddProduct(model);
		return Ok();
	}

	[HttpPut]
	public IActionResult EditProduct(ProductModel model)
	{
		_productDb.EditProduct(model);
		return View("~/Views/Product/Product.cshtml");
	}

	[HttpDelete]
	public IActionResult DeleteProduct(int id)
	{
		_productDb.DeleteProduct(id);
		return Ok();
	}
}
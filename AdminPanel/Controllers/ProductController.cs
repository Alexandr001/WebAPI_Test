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

	public IActionResult Product() => View(_productDb.GetAllProducts());
	public IActionResult Create() => View();

	[HttpGet]
	public IActionResult GetAllProducts()
	{
		return new JsonResult(_productDb.GetAllProducts());
	}

	[HttpPost]
	public IActionResult AddProduct(ProductModel model)
	{
		_productDb.AddProduct(model);
		return View("~/Views/Product/Product.cshtml");
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
		return View("~/Views/Product/Product.cshtml");
	}
}
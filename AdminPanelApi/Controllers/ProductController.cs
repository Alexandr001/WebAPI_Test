using AdminPanelApi.DataAccessLayer.Interfaces;
using AdminPanelApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanelApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
	private readonly IProductDb _productDb;
	public ProductController(IProductDb productDb)
	{
		_productDb = productDb;
	}

	[HttpGet]
	public async Task<List<ProductModel>> GetAllProducts() => 
			await _productDb.GetAllProducts();
	
	[HttpGet("{id}")]
	public async Task<ProductModel?> GetProduct(int id) => 
			await _productDb.GetProduct(id);

	[HttpPost]
	public async Task AddProduct(ProductModel model) => 
			await _productDb.AddProduct(model);

	[HttpPut]
	public async Task EditProduct(ProductModel model) => 
			await _productDb.EditProduct(model);

	[HttpDelete("{id}")]
	public async Task DeleteProduct(int id) => 
			await _productDb.DeleteProduct(id);
}
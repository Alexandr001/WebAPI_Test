using Microsoft.AspNetCore.Mvc;
using WebAPI_Test.BusinessLayer.Interfaces;
using WebAPI_Test.Models;

namespace WebAPI_Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
	private readonly IProductBl<ProductModel> _productBl;
	public ProductController(IProductBl<ProductModel> productBl) => _productBl = productBl;

	[HttpGet]
	public async Task<ActionResult<List<ProductModel>>> GetAllProducts()
	{
		List<ProductModel> productModels = await _productBl.GetAllProducts();
		return new JsonResult(productModels);
	}

	[HttpGet("{name}")]
	public async Task<ActionResult<List<ProductModel>>> GetProductByName(string name)
	{
		List<ProductModel> productByName = await _productBl.GetProductByName(name);
		return new JsonResult(productByName);
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<ProductModel>> GetProductById(Guid id)
	{
		ProductModel productById = await _productBl.GetProductById(id);
		return new JsonResult(productById);
	}
}
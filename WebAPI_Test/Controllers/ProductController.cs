using Microsoft.AspNetCore.Mvc;
using WebAPI_Test.BusinessLayer.Interfaces;
using WebAPI_Test.Models;

namespace WebAPI_Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
	private readonly IProductBl _productBl;
	public ProductController(IProductBl productBl) => _productBl = productBl;

	[HttpGet("GetAll")]
	public async Task<ActionResult<List<ProductModel>>> GetAllProducts()
	{
		List<ProductModel> productModels = await _productBl.GetAllProducts();
		return Ok(new JsonResult(productModels));
	}

	[HttpGet("GetByName/{name}")]
	public async Task<ActionResult<List<ProductModel>>> GetProductByName(string name)
	{
		List<ProductModel> productByName = await _productBl.GetProductByName(name);
		return Ok(new JsonResult(productByName));
	}

	[HttpGet("GetById/{id}")]
	public async Task<ActionResult<ProductModel>> GetProductById(int id)
	{
		ProductModel productById = await _productBl.GetProductById(id);
		return Ok(new JsonResult(productById));
	}
}
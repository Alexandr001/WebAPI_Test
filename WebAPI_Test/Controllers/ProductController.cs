using Microsoft.AspNetCore.Mvc;
using WebAPI_Test.Models;

namespace WebAPI_Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
	[HttpGet]
	public async Task<ActionResult<List<ProductModel>>> GetAllProducts()
	{
		return new JsonResult("sdfgsd");
	}

	[HttpGet("{name}")]
	public async Task<ActionResult<List<ProductModel>>> GetProductByName(string name)
	{
		return new JsonResult("sdfgsd");
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<ProductModel>> GetProductById(Guid id)
	{
		return new JsonResult("sdfgsd");
	}
}
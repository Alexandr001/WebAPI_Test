using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers;

public class HomeController : Controller
{
	public IActionResult Product() => View();
	public IActionResult Category() => View();
	
	public IActionResult Ident()
	{
		return PartialView();
	}
}
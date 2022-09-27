using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers;

public class IdentController : Controller
{
	public IActionResult Ident()
	{
		return View("_Layout");
	}
}
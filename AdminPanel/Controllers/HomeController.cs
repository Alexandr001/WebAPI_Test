﻿using AdminPanel.DataAccessLayer;
using AdminPanel.DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
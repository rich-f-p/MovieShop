﻿using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

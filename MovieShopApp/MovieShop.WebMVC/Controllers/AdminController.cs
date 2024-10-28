using ApplicationCore.Entities;
using Infastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetTopPurchased()
		{
			return View();
		}
	}
}

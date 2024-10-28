using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class CastController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

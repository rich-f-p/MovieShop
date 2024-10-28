using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using MovieShop.WebMVC.Models;
using System.Diagnostics;

namespace MovieShop.WebMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly IMovieService _movieService;

        public HomeController(ILogger<HomeController> logger, IMovieService movieService)
		{
			_movieService = movieService;
			_logger = logger;
        }

		public IActionResult Index()
		{
			var result = _movieService.GetAllMovies();
			return View(result);
		}
		
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

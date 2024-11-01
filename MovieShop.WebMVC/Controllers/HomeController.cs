using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using MovieShop.WebMVC.Models;
using System.Diagnostics;

namespace MovieShop.WebMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly IMovieServiceAsync _movieService;

        public HomeController(ILogger<HomeController> logger, IMovieServiceAsync movieService)
		{
			_movieService = movieService;
			_logger = logger;
        }

		public async Task<IActionResult> Index()
		{
			var result = await _movieService.GetAllMoviesAsync();
			return View(result);
		}
		
		public  IActionResult Privacy()
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

using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class MoviesController : Controller
	{
		private readonly IMovieService _movieService;
		public MoviesController(IMovieService movieService)
		{
			_movieService = movieService;
		}
		[HttpGet]
		public IActionResult Index()
		{
			var result = _movieService.GetAllMovies();
			return View(result);
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
	}
}

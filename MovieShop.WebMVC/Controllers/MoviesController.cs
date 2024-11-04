using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace MovieShop.WebMVC.Controllers
{
	public class MoviesController : Controller
	{
		private readonly IMovieServiceAsync _movieService;
		public MoviesController(IMovieServiceAsync movieService)
		{
			_movieService = movieService;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var result = await _movieService.GetAllMoviesAsync();
			return View(result);
		}
		public async Task<IActionResult> HighGrossMovies()
		{
			var result = await _movieService.GetHighGrossingMoviesAsync();
			return View(result);
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var result = await _movieService.GetMovieDetailsAsync(id);
			return View(result);
		}
		public async Task<IActionResult> MoviesByGenre(int id, int pageSize=30,int pageNumber=1)
		{
			var result = await _movieService.GetMoviesByGenreAsync(id,pageSize,pageNumber);
			return View(result);
		}
        [HttpPost]
        public async Task<IActionResult> Purchase(Purchase purchase)
        {
			if (ModelState.IsValid)
			{
				//need to test
				await _movieService.AddPurchaseAsync(purchase);
			}
            return View(purchase);
        }
    }
}

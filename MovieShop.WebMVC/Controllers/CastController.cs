using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class CastController : Controller
	{
        private readonly ICastServiceAsync _castService;
        public CastController(ICastServiceAsync castService)
        {
            _castService = castService;
        }
        public async Task<IActionResult> Index()
		{
            var result = await _castService.GetAllCastAsync();
			return View(result);
		}
        public async Task<IActionResult> Details(int id)
        {
            var result = await _castService.GetCastDetailsAsync(id);
            return View(result);
        }
	}
}

using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class CastController : Controller
	{
        private readonly ICastService _castService;
        public CastController(ICastService castService)
        {
            _castService = castService;
        }
        public IActionResult Index()
		{
            var result = _castService.GetAllCast();
			return View(result);
		}
	}
}

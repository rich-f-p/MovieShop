using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Infastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class AdminController : Controller
	{
        private readonly IAdminServiceAsync _adminService;
        public AdminController(IAdminServiceAsync adminService)
        {
            _adminService = adminService;
        }
        public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetTopPurchased()
		{
			return View();
		}
		public IActionResult CreateMovie() 
		{ 
			return View(); 
		}
		[HttpPost]
		public async Task<IActionResult> CreateMovie(AddMovieModel movie)
		{
            if (ModelState.IsValid)
            {
                await _adminService.CreateMovie(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
		}
	}
}

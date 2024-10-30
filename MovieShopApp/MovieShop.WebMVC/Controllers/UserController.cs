using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class UserController : Controller
	{
		private readonly IUserServiceAsync _userService;
		public UserController(IUserServiceAsync userService)
		{
			_userService = userService;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(User user)
		{

			return View(user);
		}
		public IActionResult Register()
		{
			return View();
		}
        [HttpPost]
		public async Task<IActionResult> Register(User user)
		{
			if (ModelState.IsValid)
			{
				await _userService.AddUserAsync(user);
				return RedirectToAction("Index");
			}
			return View(user);
		}
	}
}

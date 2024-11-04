using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
		public async Task<IActionResult> Login(LoginModel model)
		{
            //var result = await _userService.LoginAsync(user);
            return View("../Home/Index");
		}
	}
}

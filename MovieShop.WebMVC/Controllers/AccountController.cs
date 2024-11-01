using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.Controllers
{
	public class AccountController : Controller
	{
        private readonly IAccountServiceAsync _accountService;
        public AccountController(IAccountServiceAsync accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Index()
		{
			return View();
		}
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel user)
        {
            if (user.ConfirmPassword != user.HashedPassword)
            {
                Console.WriteLine("here");
                ViewBag.confirm = "visible";
                return View(user);
            }
            if (ModelState.IsValid)
            {
                var test = await _accountService.AddAccountAsync(user);
                return RedirectToAction("user/login");
            }
            ViewBag.confirm = "invisible";
            return View(user);
        }
    }
}

using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public LoginController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] LoginModel model)
        {
            if(ModelState.IsValid)
            {
                User? user = await _userManager.FindByEmailAsync(model.Mail);
                if (user == null)
                {
                    ViewBag.error = "Mail adresi veya şifre hatalı";
                    return View();
                }

                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.error = "Mail adresi veya şifre hatalı";
                return View();
            }

            return View();
        }

    }
}

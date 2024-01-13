using BusinessLayer.Validation.Concrete;
using DataAccessLayer.Context;
using DTOLayer;
using EntityLayer.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
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
        public async Task<IActionResult> Index([FromForm] LoginModelDTO model)
        {
            if(ModelState.IsValid)
            {
                User? user = await _userManager.FindByEmailAsync(model.Mail);
                if (user == null)
                {
                    ViewBag.error = "Mail adresi veya şifre hatalı";
                    return View();
                }

                var result2 = await _signInManager.PasswordSignInAsync(user, model.Sifre, model.RememberMe, true);
                if(result2.Succeeded)
                {
                    ViewBag.nameSurname = user.NameSurname;
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.error = "Mail adresi veya şifre hatalı";
                return View();
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<string> getNameSurname()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            return user.NameSurname;
        }
    }
}

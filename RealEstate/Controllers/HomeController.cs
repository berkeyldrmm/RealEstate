using Microsoft.AspNetCore.Mvc;
using DTOLayer;
using Microsoft.AspNetCore.Identity;
using EntityLayer.Entities;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<User> _userManager;
        private User _user => _userManager.GetUserAsync(User).Result;
        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewBag.UserId = _user.Id;
            return View();
        }
        
    }
}
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class TaleplerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

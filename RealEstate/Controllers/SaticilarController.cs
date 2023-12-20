using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class SaticilarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

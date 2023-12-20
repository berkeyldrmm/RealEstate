using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class AlicilarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

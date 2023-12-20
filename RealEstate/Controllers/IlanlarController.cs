using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class IlanlarController : Controller
    {
        private readonly IIlanService _ilanService;

        public IlanlarController(IIlanService ilanService)
        {
            _ilanService = ilanService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

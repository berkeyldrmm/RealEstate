using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class SaticilarController : Controller
    {
        private readonly ISaticiService _saticiService;

        public SaticilarController(ISaticiService saticiService)
        {
            _saticiService = saticiService;
        }

        public async Task<IActionResult> Index()
        {
            var saticilar = await _saticiService.GetAll();
            return View(saticilar);
        }
    }
}

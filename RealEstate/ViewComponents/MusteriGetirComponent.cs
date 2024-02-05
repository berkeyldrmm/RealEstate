using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RealEstate.ViewComponents
{
    public class MusteriGetirComponent : ViewComponent
    {
        private readonly IDanisanService _danisanService;

        public MusteriGetirComponent(IDanisanService danisanService)
        {
            _danisanService = danisanService;
        }

        [HttpGet]
        public async Task<IViewComponentResult> InvokeAsync(string userId)
        {
            var saticilar = await _danisanService.GetDanisanlarOfUser(userId);

            return View(saticilar);
        }
    }
}

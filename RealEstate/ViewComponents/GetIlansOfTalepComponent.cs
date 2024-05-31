using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.ViewComponents
{
    public class GetIlansOfTalepComponent : ViewComponent
    {
        private readonly IIlanService _ilanService;
        private readonly ITalepService _talepService;
        public GetIlansOfTalepComponent(IIlanService ilanService, ITalepService talepService)
        {
            _ilanService = ilanService;
            _talepService = talepService;
        }

        [HttpGet]
        public async Task<IViewComponentResult> InvokeAsync(string userId, string talepId)
        {
            Talep talep = await _talepService.GetOne(talepId);
            List<Ilan> ilanlar = await _ilanService.GetIlansForTalep(userId, talep);
            return View(ilanlar);
        }
    }
}

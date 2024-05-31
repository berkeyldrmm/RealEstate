using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.ViewComponents
{
    public class GetTalepsOfIlanComponent : ViewComponent
    {
        private readonly ITalepService _talepService;
        private readonly IIlanService _ilanService;

        public GetTalepsOfIlanComponent(ITalepService talepService, IIlanService ilanService)
        {
            _talepService = talepService;
            _ilanService = ilanService;
        }

        [HttpGet]
        public async Task<IViewComponentResult> InvokeAsync(string userId, string ilanId)
        {
            Ilan ilan = await _ilanService.GetOne(ilanId);
            List<Talep> talepler = await _talepService.GetTalepsForIlan(userId, ilan);
            return View(talepler);
        }
    }
}

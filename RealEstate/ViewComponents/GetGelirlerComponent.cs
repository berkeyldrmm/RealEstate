using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate.Models;

namespace RealEstate.ViewComponents
{
    public class GetGelirlerComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public GetGelirlerComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(User user, decimal kazanc)
        {
            List<GelirGiderModel> gelirGiderList = JsonConvert.DeserializeObject<List<GelirGiderModel>>(user.GelirGider);
            List<GelirGiderModel> gelirGiderListOfMonth = gelirGiderList.Where(g => g.Date.Month == DateTime.Now.Month).ToList();
            ViewBag.kazanc = kazanc;
            return View(gelirGiderListOfMonth);
        }
    }
}

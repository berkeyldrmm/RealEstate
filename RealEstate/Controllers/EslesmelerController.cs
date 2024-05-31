using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.Controllers
{
    public class EslesmelerController : Controller
    {
        private readonly ITalepService _talepService;
        private readonly IIlanService _ilanService;
        private readonly UserManager<User> _userManager;
        private User _user => _userManager.GetUserAsync(User).Result;
        public EslesmelerController(ITalepService talepService, IIlanService ilanService, UserManager<User> userManager)
        {
            _talepService = talepService;
            _ilanService = ilanService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Talep> talepler = await _talepService.GetAllWithAlici(_user.Id);
            List<(Talep talep, Ilan ilan)> talepIlanPairs = new List<(Talep talep, Ilan ilan)>();
            //IDictionary<Talep, Ilan> talepIlanPair = new Dictionary<Talep, Ilan>();
            foreach (var talep in talepler)
            {
                List<Ilan> ilanlar = await _ilanService.GetIlansForTalep(_user.Id, talep);

                foreach (var ilan in ilanlar)
                {
                    talepIlanPairs.Add((talep, ilan));
                }
            }

            return View(talepIlanPairs);
        }
    }
}

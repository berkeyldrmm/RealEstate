using BusinessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchingController : ControllerBase
    {
        private TalepService _talepService { get; set; }
        private IlanService _ilanService { get; set; }
        private readonly UserManager<User> _userManager ;
        private User _user => _userManager.GetUserAsync(User).Result;

        public MatchingController(TalepService talepService, UserManager<User> userManager, IlanService ilanService)
        {
            _talepService = talepService;
            _userManager = userManager;
            _ilanService = ilanService;
        }

        public async Task<IActionResult> IlanToTalep(string ilanId)
        {
            Ilan ilan = await _ilanService.GetOne(ilanId);
            if (ilan != null)
            {
                var talepler = _talepService.GetTalepsForIlan(_user.Id, ilan);
                if (talepler != null)
                {
                    return Ok(new
                    {
                        value = JsonConvert.SerializeObject(talepler)
                    });
                }
            }
            return BadRequest();
        }

        public async Task<IActionResult> TalepToIlan(string talepId)
        {
            Talep talep = await _talepService.GetOne(talepId);
            if (talep != null)
            {
                var ilanlar = _ilanService.GetIlansForTalep(_user.Id, talep);
                if (ilanlar != null)
                {
                    return Ok(new
                    {
                        value = JsonConvert.SerializeObject(ilanlar)
                    });
                }
            }
            return BadRequest();
        }
    }
}

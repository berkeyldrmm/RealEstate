using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RealEstate.Controllers
{
    public class DanisanlarController : Controller
    {
        private readonly IDanisanService _danisanService;
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private string UserId => _userManager.GetUserAsync(User).Result?.Id;
        public DanisanlarController(IDanisanService saticiService, UserManager<User> userManager, IUnitOfWork unitOfWork)
        {
            _danisanService = saticiService;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var saticilar = await _danisanService.GetDanisanlarOfUser(UserId);
            return View(saticilar);
        }

        [HttpPost]
        public async Task<IActionResult> DanisanSil(string idsJson)
        {
            var danisanlarIds = JsonConvert.DeserializeObject<List<string>>(idsJson);
            _danisanService.DeleteRange(UserId, danisanlarIds);
            var result = await _unitOfWork.SaveChanges();
            if (result <= 0)
            {
                TempData["error"] = "Danışanlar silinirken bir hata oluştu. Lütfen tekrar deneyiniz.";
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }

        public string SearchDanisan(string search)
        {
            IEnumerable<Danisan> danisanlar = _danisanService.SearchDanisan(UserId, search);
            return JsonConvert.SerializeObject(danisanlar, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }
    }
}

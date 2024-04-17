using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DTOLayer;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RealEstate.Controllers
{
    public class TaleplerController : Controller
    {
        private readonly ITalepService _talepService;
        private readonly IIlanService _ilanService;
        private readonly IDanisanService _aliciService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;
        private string UserId => _userManager.GetUserAsync(User).Result?.Id;

        public TaleplerController(ITalepService talepService, UserManager<User> userManager, IIlanService ilanService, IDanisanService aliciService, IUnitOfWork unitOfWork)
        {
            _talepService = talepService;
            _userManager = userManager;
            _ilanService = ilanService;
            _aliciService = aliciService;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var talepler = await _talepService.GetAllWithAlici(UserId);
            return View(talepler);
        }

        public IActionResult TalepEkle()
        {
            ViewBag.userId = UserId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TalepSil(string idsJson)
        {
            var taleplerIds = JsonConvert.DeserializeObject<List<string>>(idsJson);
            _talepService.DeleteRange(taleplerIds);
            var result = await _unitOfWork.SaveChanges();
            if (result <= 0)
            {
                TempData["error"] = "Talepler silinirken bir hata oluştu. Lütfen tekrar deneyiniz.";
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> TalepEkle(string talepJson)
        {
            TalepModelDTO talepModel = JsonConvert.DeserializeObject<TalepModelDTO>(talepJson);
            ViewBag.userId = UserId;


            if (ModelState.IsValid)
            {
                Talep talep = new Talep()
                {
                    Id = Guid.NewGuid().ToString() + DateTime.Now.ToString("hhmmss"),
                    Semtler = JsonConvert.SerializeObject(talepModel.Semt),
                    OdaSayisi = JsonConvert.SerializeObject(talepModel.OdaSayisi),
                    SatilikMiKiralikMi = talepModel.SatilikMiKiralikMi,
                    UserId = UserId,
                    MinFiyat = talepModel.MinFiyat,
                    MaxFiyat=talepModel.MaxFiyat,
                    
                };
                talep.IlanTalepTipiId = Convert.ToInt32(talepModel.IlanTipi);
                talep.IlanTalepTipi = await _ilanService.GetIlanTalepTipi(talep.IlanTalepTipiId);
                if (talepModel.RadioForAlici == "1")
                {
                    var alici = new Danisan()
                    {
                        Id = Guid.NewGuid().ToString() + DateTime.Now.ToString("hhmmss"),
                        AdSoyad = talepModel.AliciIsimSoyisim,
                        MailAdresi = talepModel.AliciMail,
                        TelefonNo = talepModel.AliciTelNo,
                        UserId = UserId
                    };

                    talep.AliciId = alici.Id;
                    talep.Alici = alici;
                }
                else
                {
                    talep.AliciId = talepModel.AliciId;
                    talep.Alici = await _aliciService.GetOne(talepModel.AliciId);
                }


                talep.KayitTarihi = DateTime.Now;

                if (talepModel.SatilikMiKiralikMi == "0")
                    talep.SatilikMiKiralikMi = "Kiralık";
                else
                    talep.SatilikMiKiralikMi = "Satılık";

                talep.Detaylar = talepModel.Detaylar;
                var result = await _talepService.Insert(talep);
                int saved = await _unitOfWork.SaveChanges();
                if (result && saved > 0)
                    return RedirectToAction("Index");

                ViewBag.error = "Talep eklenirken bir hata oluştu. Lütfen tekrar deneyiniz.";
            }

            return Ok();
        }

        public async Task<IActionResult> Detay(string id)
        {
            var talep = await _talepService.GetWithAlici(UserId, id);
            var semtler = JsonConvert.DeserializeObject<List<string>>(talep.Semtler);
            var odalar = JsonConvert.DeserializeObject<List<string>>(talep.OdaSayisi);
            ViewBag.SemtlerVeOdalar = new {
                semtler=semtler,
                odalar=odalar
            };
            return View(talep);
        }

        public string getCountOfTalepler()
        {
            var counts = _talepService.GetCountsOfTalepler();
            var countsOfTalepler = JsonConvert.SerializeObject(counts);
            return countsOfTalepler;
        }

        public string getSatilikKiralik()
        {
            var counts = _talepService.GetSatilikKiralik();
            var countsOfSatilik = JsonConvert.SerializeObject(counts);
            return countsOfSatilik;
        }
    }
}

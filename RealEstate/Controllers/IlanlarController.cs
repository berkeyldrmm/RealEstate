using BusinessLayer.Abstract;
using DTOLayer;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RealEstate.Controllers
{
    public class IlanlarController : Controller
    {
        private readonly IIlanService _ilanService;
        private readonly IDanisanService _saticiService;
        private readonly UserManager<User> _userManager;
        private readonly IPortfoyService _portfoyService;
        private readonly IUnitOfWork _unitOfWork;
        private string UserId => _userManager.GetUserAsync(User).Result?.Id;
        public IlanlarController(IIlanService ilanService, IDanisanService saticiService, UserManager<User> userManager, IPortfoyService portfoyService, IUnitOfWork unitOfWork)
        {
            _ilanService = ilanService;
            _saticiService = saticiService;
            _userManager = userManager;
            _portfoyService = portfoyService;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var ilanlar = await _ilanService.GetAllWithSatici(UserId);

            return View(ilanlar);
        }

        public IActionResult IlanEkle()
        {
            ViewBag.userId = UserId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IlanSil(string idsJson)
        {
            var ilanlarIds = JsonConvert.DeserializeObject<List<string>>(idsJson);
            _ilanService.DeleteRange(ilanlarIds);
            var result = await _unitOfWork.SaveChanges();
            if (result <= 0)
            {
                TempData["error"] = "İlanlar silinirken bir hata oluştu. Lütfen tekrar deneyiniz.";
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> IlanEkle(IlanModelDTO ilanModel)
        {
            if (ilanModel.radioForKomisyon == "0" && ilanModel.Komisyon==null)
            {
                ViewBag.error = "Komisyon bedeli giriniz.";
                return View();
            }
            if (ModelState.IsValid)
            {
                Ilan ilan = new Ilan()
                {
                    Id = Guid.NewGuid().ToString() + DateTime.Now.ToString("hhmmss"),
                    IlanBaslik = ilanModel.IlanBaslik,
                    PortfoyFiyati = ilanModel.Fiyat,
                    SatilikMiKiralikMi = ilanModel.SatilikMiKiralikMi,
                    SatisDurumu = false,
                    UserId = UserId,
                    Sehir = ilanModel.Sehir,
                    Semt = ilanModel.Semt,
                    Mahalle = ilanModel.Mahalle
                };
                ilan.IlanTalepTipiId = Convert.ToInt32(ilanModel.IlanTipi);
                ilan.IlanTalepTipi = await _ilanService.GetIlanTalepTipi(ilan.IlanTalepTipiId);
                if (ilanModel.RadioForSatici == "1")
                {
                    var satici = new Danisan()
                    {
                        Id = Guid.NewGuid().ToString() + DateTime.Now.ToString("hhmmss"),
                        AdSoyad = ilanModel.SaticiIsimSoyisim,
                        MailAdresi = ilanModel.SaticiMail,
                        TelefonNo = ilanModel.SaticiTelNo,
                        UserId = UserId
                    };

                    ilan.SaticiId = satici.Id;
                    ilan.Satici = satici;
                }
                else
                {
                    ilan.SaticiId = ilanModel.SaticiId;
                    ilan.Satici = await _saticiService.GetOne(ilanModel.SaticiId);
                }
                var portfoy = new Portfoy();
                switch (ilan.IlanTalepTipiId)
                {
                    case 1:

                        portfoy = new Dukkan()
                        {
                            AdaNo = ilanModel.AdaNo,
                            Aidat = Convert.ToInt32(ilanModel.Aidat),
                            Asansor = Convert.ToBoolean(Convert.ToInt32(ilanModel.Asansor)),
                            Otopark = Convert.ToBoolean(Convert.ToInt32(ilanModel.Otopark)),
                            BinaYasi = ilanModel.BinaYasi,
                            BulunduguKat = Convert.ToInt32(ilanModel.BulunduguKat),
                            EsyaliMi = Convert.ToBoolean(Convert.ToInt32(ilanModel.Esyali)),
                            Isıtma = ilanModel.Isıtma,
                            KatSayisi = Convert.ToInt32(ilanModel.KatSayisi),
                            KrediyeUygun = Convert.ToBoolean(Convert.ToInt32(ilanModel.KrediyeUygun)),
                            KullanimDurumu = ilanModel.KullanimDurumu,
                            MetrekareBrut = Convert.ToInt32(ilanModel.MetrekareBrut),
                            ParselNo = ilanModel.ParselNo,
                            OdaSayisi = ilanModel.OdaSayisi
                        };

                        break;
                    case 2:
                        portfoy = new Arsa()
                        {
                            AdaNo = ilanModel.AdaNo,
                            ParselNo = ilanModel.ParselNo,
                            ImarDurumu = Convert.ToBoolean(Convert.ToInt32(ilanModel.ImarDurumu)),
                            KatKarsiliginaUygun = Convert.ToBoolean(Convert.ToInt32(ilanModel.KatKarsiliginaUygun)),
                            PaftaNo = ilanModel.PaftaNo,
                            TapuDurumu = Convert.ToBoolean(Convert.ToInt32(ilanModel.TapuDurumu))
                        };
                        break;
                    case 3:
                        portfoy = new Depo()
                        {
                            AdaNo = ilanModel.AdaNo,
                            ParselNo = ilanModel.ParselNo
                        };
                        break;
                    case 4:
                        portfoy = new Tarla()
                        {
                            AdaNo = ilanModel.AdaNo,
                            ParselNo = ilanModel.ParselNo,
                            PaftaNo = ilanModel.PaftaNo,
                            TapuDurumu = Convert.ToBoolean(Convert.ToInt32(ilanModel.TapuDurumu)),
                            ImarDurumu = Convert.ToBoolean(Convert.ToInt32(ilanModel.ImarDurumu))
                        };
                        break;
                    case 5:
                        portfoy = new Daire()
                        {
                            AdaNo = ilanModel.AdaNo,
                            Aidat = Convert.ToInt32(ilanModel.Aidat),
                            Asansor = Convert.ToBoolean(Convert.ToInt32(ilanModel.Asansor)),
                            Otopark = Convert.ToBoolean(Convert.ToInt32(ilanModel.Otopark)),
                            BinaYasi = ilanModel.BinaYasi,
                            BulunduguKat = Convert.ToInt32(ilanModel.BulunduguKat),
                            EsyaliMi = Convert.ToBoolean(Convert.ToInt32(ilanModel.Esyali)),
                            Isıtma = ilanModel.Isıtma,
                            KatSayisi = Convert.ToInt32(ilanModel.KatSayisi),
                            KrediyeUygun = Convert.ToBoolean(Convert.ToInt32(ilanModel.KrediyeUygun)),
                            KullanimDurumu = ilanModel.KullanimDurumu,
                            MetrekareBrut = Convert.ToInt32(ilanModel.MetrekareBrut),
                            ParselNo = ilanModel.ParselNo,
                            OdaSayisi = ilanModel.OdaSayisi,
                            SiteMi = Convert.ToBoolean(Convert.ToInt32(ilanModel.SiteMi))
                        };
                        break;
                    default:
                        break;
                }

                portfoy.Id = ilan.Id;
                portfoy.MetrekareNet = ilanModel.MetrekareNet;
                portfoy.MetrekareFiyat = Math.Ceiling(ilan.PortfoyFiyati / Convert.ToInt32(portfoy.MetrekareNet));
                bool portfoyresult = await _portfoyService.PortfoyEkle(portfoy);
                if (!portfoyresult)
                {
                    ViewBag.error = "İlan eklenirken bir hata oluştu. Lütfen tekrar deneyiniz.";
                    return View();
                }

                ilan.KayitTarihi = DateTime.Now;

                if (ilanModel.radioForKomisyon == "0")
                    ilan.Komisyon = Convert.ToDecimal(ilanModel.Komisyon);
                else
                {
                    if(ilanModel.SatilikMiKiralikMi=="0")
                        ilan.Komisyon = ilanModel.Fiyat;
                    else
                        ilan.Komisyon = ilanModel.Fiyat * 4 / 100;
                }

                if (ilanModel.SatilikMiKiralikMi == "0")
                    ilan.SatilikMiKiralikMi = "Kiralık";
                else
                    ilan.SatilikMiKiralikMi = "Satılık";

                ilan.Detaylar = ilanModel.Detaylar;
                var result = await _ilanService.Insert(ilan);
                int saved = await _unitOfWork.SaveChanges();
                if (result && saved > 0)
                    return RedirectToAction("Index");

                ViewBag.error = "İlan eklenirken bir hata oluştu. Lütfen tekrar deneyiniz.";
            }
            return View();
        }

        public async Task<IActionResult> IlanSat(string id, [FromQuery] string kazanc)
        {
            bool result = await _ilanService.IlanSat(id, kazanc);
            var saved = await _unitOfWork.SaveChanges();
            if (!result || saved<=0)
            {
                TempData["error"] = "İlanlar silinirken bir hata oluştu. Lütfen tekrar deneyiniz.";
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return Ok();
        }

        public async Task<IActionResult> Detay(string id)
        {
            var ilan = await _ilanService.GetWithSatici(UserId,id);
            return View(ilan);
        }
    }
}

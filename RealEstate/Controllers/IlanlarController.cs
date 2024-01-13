using BusinessLayer.Abstract;
using DTOLayer;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class IlanlarController : Controller
    {
        private readonly IIlanService _ilanService;
        private readonly ISaticiService _saticiService;
        private readonly UserManager<User> _userManager;
        private readonly IPortfoyService _portfoyService;
        private readonly IUnitOfWork _unitOfWork;
        public IlanlarController(IIlanService ilanService, ISaticiService saticiService, UserManager<User> userManager, IPortfoyService portfoyService, IUnitOfWork unitOfWork)
        {
            _ilanService = ilanService;
            _saticiService = saticiService;
            _userManager = userManager;
            _portfoyService = portfoyService;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var ilanlar = await _ilanService.GetAllWithSatici();

            return View(ilanlar);
        }

        public IActionResult IlanEkle()
        {
            return View();
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
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                Ilan ilan = new Ilan()
                {
                    Id = Guid.NewGuid().ToString() + DateTime.Now.ToString("hhmmss"),
                    PortfoyFiyati = ilanModel.Fiyat,
                    SatilikMiKiralikMi = ilanModel.SatilikMiKiralikMi,
                    SatisDurumu = false,
                    UserId=user.Id,
                    User=user
                };
                ilan.IlanTalepTipiId = Convert.ToInt32(ilanModel.IlanTipi);
                if (ilanModel.RadioForSatici == "1")
                {
                    var satici = new Satici()
                    {
                        Id = Guid.NewGuid().ToString() + DateTime.Now.ToString("hhmmss"),
                        AdSoyad = ilanModel.SaticiIsimSoyisim,
                        MailAdresi = ilanModel.SaticiMail,
                        TelefonNo = ilanModel.SaticiTelNo,
                        UserId = user.Id,
                        User=user
                    };
                    
                    ilan.SaticiId=satici.Id;
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
                            MetrekareFiyat = Convert.ToInt32(ilanModel.MetrekareFiyat),
                            ParselNo= ilanModel.ParselNo,
                            OdaSayisi=ilanModel.OdaSayisi
                        };

                        break;
                    case 2:
                        portfoy = new Arsa()
                        {
                            AdaNo = ilanModel.AdaNo,
                            MetrekareFiyat = Convert.ToInt32(ilanModel.MetrekareFiyat),
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
                            MetrekareFiyat = Convert.ToInt32(ilanModel.MetrekareFiyat),
                            ParselNo = ilanModel.ParselNo
                        };
                        break;
                    case 4:
                        portfoy = new Tarla()
                        {
                            AdaNo = ilanModel.AdaNo,
                            MetrekareFiyat = Convert.ToInt32(ilanModel.MetrekareFiyat),
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
                            MetrekareFiyat = Convert.ToInt32(ilanModel.MetrekareFiyat),
                            ParselNo = ilanModel.ParselNo,
                            OdaSayisi = ilanModel.OdaSayisi,
                            SiteMi = Convert.ToBoolean(Convert.ToInt32(ilanModel.SiteMi))
                        };
                        break;
                    default:
                        break;
                }

                portfoy.MetrekareNet = ilanModel.MetrekareNet;
                
                portfoy.Id = ilan.Id;
                bool portfoyresult = await _portfoyService.PortfoyEkle(portfoy);
                if (!portfoyresult)
                {
                    ViewBag.error = "Bir hata oluştu. Lütfen tekrar deneyiniz.";
                    return View();
                }

                ilan.SatilikMiKiralikMi = ilanModel.SatilikMiKiralikMi;
                ilan.KayitTarihi=DateTime.Now;

                if (ilanModel.radioForKomisyon == "0")
                {
                    ilan.Komisyon = Convert.ToDecimal(ilanModel.Komisyon);
                }
                else
                {
                    ilan.Komisyon = ilanModel.Fiyat * 4 / 100;
                }
                ilan.IlanFiyati = ilan.PortfoyFiyati + ilan.Komisyon;
                ilan.Detaylar = ilanModel.Detaylar;
                var result = await _ilanService.Insert(ilan);
                int saved = await _unitOfWork.SaveChanges();
                if (result && saved > 0)
                {
                    return RedirectToAction("Index");
                }

                ViewBag.error = "Bir hata meydana geldi. Lütfen tekrar deneyin.";
                return View();
            }
            return View();
        }
    }
}

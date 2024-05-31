using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class MuhasebeController : Controller
    {
        private readonly IIlanService _ilanService;
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private User _user => _userManager.GetUserAsync(User).Result;
        public MuhasebeController(IIlanService ilanService, UserManager<User> userManager, IUnitOfWork unitOfWork)
        {
            _ilanService = ilanService;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.User = _user;
            List<(string ilanBaslik, decimal kazanc)> kazancsOfMonth = await _ilanService.GetKazancsOfMonth(_user.Id);
            return View(kazancsOfMonth);
        }

        [HttpPost]
        public async Task<IActionResult> GelirGiderEkle(GelirGiderModel gelirGiderModel)
        {
            List<GelirGiderModel> gelirGiderModelList = JsonConvert.DeserializeObject<List<GelirGiderModel>>(_user.GelirGider);
            gelirGiderModel.Date= DateTime.Now;
            gelirGiderModelList.Add(gelirGiderModel);
            string gelirGiderModelJson = JsonConvert.SerializeObject(gelirGiderModelList);
            _user.GelirGider= gelirGiderModelJson;
            var result = await _userManager.UpdateAsync(_user);
            if(result.Succeeded)
            {
                int result1 = await _unitOfWork.SaveChanges();
                if (result1 > 0)
                {
                    TempData["success"] = "İşlem başarılı.";
                    return RedirectToAction("Index");
                }
            }
            TempData["success"] = "Bir hata oluştu.";
            return RedirectToAction("Index");
        }

    }
}

using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate.Models;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Musteriler : ControllerBase
    {
        private readonly ISaticiService _saticiService;
        private readonly IAliciService _aliciService;

        public Musteriler(ISaticiService saticiService, IAliciService aliciService)
        {
            _saticiService = saticiService;
            _aliciService = aliciService;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var saticilar = await _saticiService.GetAll();
            var alicilar = await _aliciService.GetAll();

            return JsonConvert.SerializeObject(new MusterilerVM()
            {
                Saticilar = saticilar,
                Alicilar = alicilar
            });
        }
    }
}

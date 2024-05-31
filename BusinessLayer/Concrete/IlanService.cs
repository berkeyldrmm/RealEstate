using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLayer.Concrete
{
    public class IlanService : IIlanService
    {
        private readonly IIlanDal _ilanRepository;

        public IlanService(IIlanDal ilanRepository)
        {
            _ilanRepository = ilanRepository;
        }

        public bool DeleteAsync(Ilan item)
        {
            return _ilanRepository.Delete(item);
        }

        public void DeleteRange(IEnumerable<string> Ids)
        {
            var items = _ilanRepository.GetRange(Ids);
            _ilanRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Ilan>> GetAll()
        {
            return _ilanRepository.ReadAll();
        }

        public Task<Ilan> GetOne(string id)
        {
            return _ilanRepository.Read(id);
        }

        public async Task<bool> Insert(Ilan item)
        {
            return await _ilanRepository.Insert(item);
        }

        public Task<bool> Update(Ilan item)
        {
            return _ilanRepository.Update(item);
        }

        public async Task<IEnumerable<Ilan>> GetAllWithSatici(string userId)
        {
            return await _ilanRepository.GetAllWithSatici(userId);
        }
        public async Task<Ilan> GetWithSatici(string userId, string id)
        {
            return await _ilanRepository.GetWithSatici(userId, id);
        }

        public Task<IlanTalepTipi> GetIlanTalepTipi(int id)
        {
            return _ilanRepository.GetIlanTalepTipi(id);
        }

        public Task<bool> IlanSat(string id, string kazanc)
        {
            return _ilanRepository.IlanSat(id, kazanc);
        }

        public object GetCountsOfIlanlar(string userId)
        {
            return _ilanRepository.GetCountsOfIlanlar(userId);
        }

        public object GetSatilikKiralik(string userId)
        {
            return _ilanRepository.GetSatilikKiralik(userId);
        }

        public Task<IEnumerable<Ilan>> GetByFilters(string userId, string satilikKiralik, int ilanTipi, string satisDurumu, string minFiyat, string maxFiyat, string sirala, string search)
        {
            var expressions = new List<Expression<Func<Ilan, bool>>>();

            if (satilikKiralik != "0")
                expressions.Add(i => i.SatilikMiKiralikMi == satilikKiralik);

            if (ilanTipi != 0)
                expressions.Add(i => i.IlanTalepTipiId == ilanTipi);

            if (satisDurumu != "-1")
                expressions.Add(i => i.SatisDurumu == Convert.ToBoolean(Convert.ToInt16(satisDurumu)));

            if(minFiyat != null && minFiyat.Length > 2)
            {
                var minimumFiyat = Convert.ToDecimal(minFiyat);
                if (minimumFiyat > 0)
                    expressions.Add(i => i.PortfoyFiyati >= minimumFiyat);
            }

            if (maxFiyat!=null && maxFiyat.Length > 2)
            {
                var maximumFiyat = Convert.ToDecimal(maxFiyat);
                if (maximumFiyat > 0)
                    expressions.Add(i => i.PortfoyFiyati <= maximumFiyat);
            }

            if (search != null && search.Length > 2)
            {
                expressions.Add(i => i.IlanBaslik.Contains(search) || i.Sehir.Contains(search) || i.Semt.Contains(search) || i.Mahalle.Contains(search) || i.Satici.AdSoyad.Contains(search));
            }

            return _ilanRepository.GetByFilters(userId, expressions, sirala);
        }

        public async Task<List<Ilan>> GetIlansForTalep(string userId, Talep talep)
        {
            List<Expression<Func<Ilan, bool>>> expressions = new List<Expression<Func<Ilan, bool>>>();

            expressions.Add(i => JsonConvert.DeserializeObject<List<string>>(talep.Semtler).ToList().Any(s => s == i.Semt) && talep.Sehir==i.Sehir);

            expressions.Add(i => talep.MinFiyat <= i.PortfoyFiyati && talep.MaxFiyat >= i.PortfoyFiyati);

            if (talep.IlanTalepTipiId == 5)
            {
                expressions.Add(i => JsonConvert.DeserializeObject<List<string>>(talep.OdaSayisi).ToList().Any(o => o == i.Daire.OdaSayisi));
            }
            else if (talep.IlanTalepTipiId == 1)
            {
                expressions.Add(i => JsonConvert.DeserializeObject<List<string>>(talep.OdaSayisi).ToList().Any(o => o == i.Dukkan.OdaSayisi));
            }

            expressions.Add(i => talep.SatilikMiKiralikMi == i.SatilikMiKiralikMi);

            expressions.Add(i => talep.IlanTalepTipiId == i.IlanTalepTipiId);

            expressions.Add(i => i.SatisDurumu==false);

            return await _ilanRepository.GetIlansForTalep(userId, expressions);
        }

        public async Task<List<(string ilanBaslik, decimal kazanc)>> GetKazancsOfMonth(string userId)
        {
            return await _ilanRepository.GetKazancsOfMonth(userId);
        }
    }
}

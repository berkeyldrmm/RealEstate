using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TalepService : ITalepService
    {
        private readonly ITalepDal _talepRepository;

        public TalepService(ITalepDal talepRepository)
        {
            _talepRepository = talepRepository;
        }

        public bool DeleteAsync(Talep item)
        {
            return _talepRepository.Delete(item);
        }

        public void DeleteRange(string userId, IEnumerable<string> Ids)
        {
            var items = _talepRepository.GetRange(userId, Ids);
            _talepRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Talep>> GetAll()
        {
            return _talepRepository.ReadAll();
        }

        public async Task<IEnumerable<Talep>> GetAllWithAlici(string userId)
        {
            return await _talepRepository.GetAllWithAlici(userId);
        }

        public object GetCountsOfTalepler(string userId)
        {
            return _talepRepository.GetCountsOfTalepler(userId);
        }

        public Task<IlanTalepTipi> GetIlanTalepTipi(int id)
        {
            return _talepRepository.GetIlanTalepTipi(id);
        }

        public Task<Talep> GetOne(string id)
        {
            return _talepRepository.Read(id);
        }

        public object GetSatilikKiralik(string userId)
        {
            return _talepRepository.GetSatilikKiralik(userId);
        }

        public async Task<Talep> GetWithAlici(string userId, string id)
        {
            return await _talepRepository.GetWithAlici(userId, id);
        }

        public async Task<bool> Insert(Talep item)
        {
            return await _talepRepository.Insert(item);
        }

        public Task<bool> Update(Talep item)
        {
            return _talepRepository.Update(item);
        }

        public Task<IEnumerable<Talep>> GetByFilters(string userId, string satilikKiralik, int ilanTipi, string sirala, string search)
        {
            var expressions = new List<Expression<Func<Talep, bool>>>();

            if (satilikKiralik != "0")
                expressions.Add(t => t.SatilikMiKiralikMi == satilikKiralik);

            if (ilanTipi != 0)
                expressions.Add(t => t.IlanTalepTipiId == ilanTipi);

            if (search != null && search.Length > 2)
            {
                expressions.Add(t => t.TalepBaslik.Contains(search) || t.Sehir.Contains(search) || t.Alici.AdSoyad.Contains(search));
            }

            return _talepRepository.GetByFilters(userId, expressions, sirala);
        }

        public async Task<List<Talep>> GetTalepsForIlan(string userId, Ilan ilan)
        {
            List<Expression<Func<Talep, bool>>> expressions = new List<Expression<Func<Talep, bool>>>();
            expressions.Add(t => t.Semtler.Contains("\""+ilan.Semt+"\"") && t.Sehir == ilan.Sehir);
            expressions.Add(t => t.MinFiyat <= ilan.PortfoyFiyati && t.MaxFiyat >= ilan.PortfoyFiyati);

            if (ilan.IlanTalepTipiId == 5)
            {
                expressions.Add(t => t.OdaSayisi.Contains("\""+ilan.Daire.OdaSayisi+"\""));
            }
            else if (ilan.IlanTalepTipiId == 1)
            {
                expressions.Add(t => t.OdaSayisi.Contains("\"" + ilan.Dukkan.OdaSayisi + "\""));
            }

            expressions.Add(t => t.SatilikMiKiralikMi == ilan.SatilikMiKiralikMi);

            expressions.Add(t => t.IlanTalepTipiId == ilan.IlanTalepTipiId);

            return await _talepRepository.GetTalepsForIlan(userId, expressions);

        }
    }
}

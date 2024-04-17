using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIlanService : IGenericService<Ilan>
    {
        public Task<IEnumerable<Ilan>> GetAllWithSatici(string userId);
        public Task<Ilan> GetWithSatici(string userId, string id);
        public Task<IlanTalepTipi> GetIlanTalepTipi(int id);
        void DeleteRange(IEnumerable<string> Ids);
        public Task<bool> IlanSat(string id, string kazanc);
        public object GetCountsOfIlanlar();
        public object GetSatilikKiralik();
        public Task<IEnumerable<Ilan>> GetByFilters(string satilikKiralik, int ilanTipi, string satisDurumu, string minFiyat, string maxFiyat, string sirala, string search);
    }
}

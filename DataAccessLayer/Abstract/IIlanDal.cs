using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IIlanDal : IGenericDal<Ilan>
    {
        public Task<IEnumerable<Ilan>> GetAllWithSatici(string userId);
        public Task<Ilan> GetWithSatici(string userID, string id);
        public Task<IlanTalepTipi> GetIlanTalepTipi(int id);
        IEnumerable<Ilan> GetRange(IEnumerable<string> Ids);
        public Task<bool> IlanSat(string id, string kazanc);
        public object GetCountsOfIlanlar(string userId);
        public object GetSatilikKiralik(string userId);
        public Task<List<Ilan>> GetIlansForTalep(string userId, List<Expression<Func<Ilan, bool>>> expressions);
        public Task<IEnumerable<Ilan>> GetByFilters(string userId, List<Expression<Func<Ilan, bool>>> expressions, string sirala);
        public Task<List<(string ilanBaslik, decimal kazanc)>> GetKazancsOfMonth(string userId);
    }
}

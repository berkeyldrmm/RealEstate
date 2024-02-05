using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IIlanDal : IGenericDal<Ilan>
    {
        public Task<IEnumerable<Ilan>> GetAllWithSatici(string userId);
        public Task<Ilan> GetWithSatici(string userId, string id);
        public Task<IlanTalepTipi> GetIlanTalepTipi(int id);
        IEnumerable<Ilan> GetRange(IEnumerable<string> Ids);
        public Task<bool> IlanSat(string id, string kazanc);
    }
}

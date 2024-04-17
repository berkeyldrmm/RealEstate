using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITalepDal : IGenericDal<Talep>
    {
        public Task<IEnumerable<Talep>> GetAllWithAlici(string userId);
        public Task<Talep> GetWithAlici(string userId, string id);
        public Task<IlanTalepTipi> GetIlanTalepTipi(int id);
        IEnumerable<Talep> GetRange(IEnumerable<string> Ids);
        public object GetCountsOfTalepler();
        public object GetSatilikKiralik();
    }
}

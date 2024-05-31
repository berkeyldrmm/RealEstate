using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITalepService : IGenericService<Talep>
    {
        public Task<IEnumerable<Talep>> GetAllWithAlici(string userId);
        public Task<Talep> GetWithAlici(string userId, string id);
        public Task<IlanTalepTipi> GetIlanTalepTipi(int id);
        void DeleteRange(string userId, IEnumerable<string> Ids);
        public object GetCountsOfTalepler(string userId);
        public object GetSatilikKiralik(string userId);
        public Task<List<Talep>> GetTalepsForIlan(string userId, Ilan ilan);
        public Task<IEnumerable<Talep>> GetByFilters(string userId, string satilikKiralik, int ilanTipi, string sirala, string search);
    }
}

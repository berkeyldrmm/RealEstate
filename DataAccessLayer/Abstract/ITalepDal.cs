using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITalepDal : IGenericDal<Talep>
    {
        public Task<IEnumerable<Talep>> GetAllWithAlici(string userId);
        public Task<Talep> GetWithAlici(string userId, string id);
        public Task<IlanTalepTipi> GetIlanTalepTipi(int id);
        IEnumerable<Talep> GetRange(string userId, IEnumerable<string> Ids);
        public object GetCountsOfTalepler(string userId);
        public object GetSatilikKiralik(string userId);
        public Task<List<Talep>> GetTalepsForIlan(string userId, List<Expression<Func<Talep, bool>>> expressions);
        public Task<IEnumerable<Talep>> GetByFilters(string userId, List<Expression<Func<Talep, bool>>> expressions, string sirala);
    }
}

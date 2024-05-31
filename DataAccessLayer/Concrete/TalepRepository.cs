using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class TalepRepository : GenericRepository<Talep>, ITalepDal
    {
        public DbSet<IlanTalepTipi> IlanTalepTipi => _context.Set<IlanTalepTipi>();
        public TalepRepository(RealEstateDBContext context) : base(context)
        {
        }
        public IQueryable<Talep> EntityOfUser(string userId) => Entity.Where(i => i.UserId == userId);
        public async Task<IEnumerable<Talep>> GetAllWithAlici(string userId)
        {
            return await EntityOfUser(userId).Include(t => t.Alici).Include(t => t.IlanTalepTipi).ToListAsync();
        }

        public async Task<IlanTalepTipi> GetIlanTalepTipi(int id)
        {
            return await IlanTalepTipi.FirstOrDefaultAsync(t => t.Id == id);
        }

        public IEnumerable<Talep> GetRange(string userId, IEnumerable<string> Ids)
        {
            return EntityOfUser(userId).Where(talep => Ids.Contains(talep.Id)).ToList();
        }

        public async Task<Talep> GetWithAlici(string userId, string id)
        {
            return await EntityOfUser(userId).Include(t => t.Alici).Include(t => t.IlanTalepTipi).FirstOrDefaultAsync(t => t.Id == id);
        }

        public object GetCountsOfTalepler(string userId)
        {
            return new
            {
                CountOfArsa = EntityOfUser(userId).Where(i => i.IlanTalepTipiId == 2).Count(),
                CountOfTarla = EntityOfUser(userId).Where(i => i.IlanTalepTipiId == 4).Count(),
                CountOfDukkan = EntityOfUser(userId).Where(i => i.IlanTalepTipiId == 1).Count(),
                CountOfDepo = EntityOfUser(userId).Where(i => i.IlanTalepTipiId == 3).Count(),
                CountOfDaire = EntityOfUser(userId).Where(i => i.IlanTalepTipiId == 5).Count()
            };
        }

        public object GetSatilikKiralik(string userId)
        {
            return new
            {
                Satilik = EntityOfUser(userId).Where(i => i.SatilikMiKiralikMi == "Satılık").Count(),
                Kiralik = EntityOfUser(userId).Where(i => i.SatilikMiKiralikMi == "Kiralık").Count()
            };
        }

        public async Task<IEnumerable<Talep>> GetByFilters(string userId, List<Expression<Func<Talep, bool>>> expressions, string sirala)
        {
            IQueryable<Talep> query = EntityOfUser(userId).Include(i => i.Alici).Include(i => i.IlanTalepTipi);

            foreach (var expression in expressions)
            {
                query = query.Where(expression);
            }

            if (sirala != null)
            {
                if (sirala.ToLower() == "ilkyeni")
                {
                    query = query.OrderByDescending(i => i.KayitTarihi);
                }
                if (sirala.ToLower() == "ilkeski")
                {
                    query = query.OrderBy(i => i.KayitTarihi);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<List<Talep>> GetTalepsForIlan(string userId, List<Expression<Func<Talep, bool>>> expressions)
        {
            IQueryable<Talep> query = EntityOfUser(userId).Include(t => t.Alici).Include(t => t.IlanTalepTipi);
            foreach (var expression in expressions)
            {
                query = query.Where(expression);
            }

            return await query.ToListAsync();
        }
    }
}

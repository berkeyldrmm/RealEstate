using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class IlanRepository : GenericRepository<Ilan>, IIlanDal
    {
        public DbSet<IlanTalepTipi> IlanTalepTipi => _context.Set<IlanTalepTipi>();
        public IlanRepository(RealEstateDBContext context) : base(context)
        {
        }

        public IQueryable<Ilan> EntityOfUser(string userId) => Entity.Where(i => i.UserId == userId);

        public async Task<IEnumerable<Ilan>> GetAllWithSatici(string userId)
        {
            return await EntityOfUser(userId).Include(i => i.Satici).Include(i => i.IlanTalepTipi).ToListAsync();
        }

        public async Task<Ilan> GetWithSatici(string userId, string id)
        {
            return await EntityOfUser(userId)
                .Include(i => i.Satici)
                .Include(i => i.IlanTalepTipi)
                .Include(i=>i.Arsa)
                .Include(i=>i.Daire)
                .Include(i=>i.Depo)
                .Include(i=>i.Dukkan)
                .Include(i=>i.Tarla)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IlanTalepTipi> GetIlanTalepTipi(int id)
        {
            return await IlanTalepTipi.FirstOrDefaultAsync(i => i.Id == id);
        }

        public IEnumerable<Ilan> GetRange(IEnumerable<string> Ids)
        {
            return Entity.Where(ilan => Ids.Contains(ilan.Id)).ToList();
        }

        public async Task<bool> IlanSat(string id, string kazanc)
        {
            Ilan ilan = await Read(id);
            ilan.SatisDurumu = true;
            ilan.Kazanc=Convert.ToDecimal(kazanc);
            bool result = await Update(ilan);
            return result;
        }

        public object GetCountsOfIlanlar(string userId)
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

        public async Task<IEnumerable<Ilan>> GetByFilters(string userId, List<Expression<Func<Ilan, bool>>> expressions, string sirala)
        {
            IQueryable<Ilan> query = EntityOfUser(userId).Include(i => i.Satici).Include(i => i.IlanTalepTipi);

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
                if (sirala.ToLower() == "artanfiyat")
                {
                    query = query.OrderBy(i => i.PortfoyFiyati);
                }
                if (sirala.ToLower() == "azalanfiyat")
                {
                    query = query.OrderByDescending(i => i.PortfoyFiyati);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<List<Ilan>> GetIlansForTalep(string userId, List<Expression<Func<Ilan, bool>>> expressions)
        {
            IQueryable<Ilan> query = EntityOfUser(userId).Include(i => i.Satici).Include(i => i.Dukkan).Include(i => i.Daire).Include(i => i.IlanTalepTipi);
            
            foreach (var expression in expressions)
            {
                query = query.Where(expression);
            }

            return await query.ToListAsync();
        }

        public async Task<List<(string ilanBaslik, decimal kazanc)>> GetKazancsOfMonth(string userId)
        {
            var kazancsOfMonth = await EntityOfUser(userId).Where(i => i.KayitTarihi.Month == DateTime.Now.Month && i.KayitTarihi.Year == DateTime.Now.Year).Where(i => i.SatisDurumu).Select(i => new {i.IlanBaslik, i.Kazanc}).ToListAsync();
            List<(string ilanBaslik, decimal kazanc)> kazancsOfMonthTuple = new List<(string ilanBaslik, decimal kazanc)>();
            foreach (var kazanc in kazancsOfMonth)
            {
                kazancsOfMonthTuple.Add((kazanc.IlanBaslik, kazanc.Kazanc));
            }
            return kazancsOfMonthTuple;
        }
    }
}

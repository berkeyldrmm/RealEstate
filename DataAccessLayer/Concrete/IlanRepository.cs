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

        public object GetCountsOfIlanlar()
        {
            return new
            {
                CountOfArsa = Entity.Where(i => i.IlanTalepTipiId == 2).Count(),
                CountOfTarla = Entity.Where(i => i.IlanTalepTipiId == 4).Count(),
                CountOfDukkan = Entity.Where(i => i.IlanTalepTipiId == 1).Count(),
                CountOfDepo = Entity.Where(i => i.IlanTalepTipiId == 3).Count(),
                CountOfDaire = Entity.Where(i => i.IlanTalepTipiId == 5).Count()
            };
            
        }

        public object GetSatilikKiralik()
        {
            return new
            {
                Satilik = Entity.Where(i => i.SatilikMiKiralikMi == "Satılık").Count(),
                Kiralik = Entity.Where(i => i.SatilikMiKiralikMi == "Kiralık").Count()
            };
        }

        public async Task<IEnumerable<Ilan>> GetByFilters(List<Expression<Func<Ilan, bool>>> expressions, string sirala)
        {
            IQueryable<Ilan> query = Entity.Include(i => i.Satici).Include(i => i.IlanTalepTipi);

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
    }
}

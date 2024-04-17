using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Talep> GetRange(IEnumerable<string> Ids)
        {
            return Entity.Where(talep => Ids.Contains(talep.Id)).ToList();
        }

        public async Task<Talep> GetWithAlici(string userId, string id)
        {
            return await EntityOfUser(userId).Include(t => t.Alici).Include(t => t.IlanTalepTipi).FirstOrDefaultAsync(t => t.Id == id);
        }

        public object GetCountsOfTalepler()
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
    }
}

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
    }
}

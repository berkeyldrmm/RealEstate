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
        public IlanRepository(RealEstateDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Ilan>> GetAllWithSatici()
        {
            return await Entity.Include(i => i.Satici).Include(i => i.Portfoy).ToListAsync();
        }

        public async Task<Ilan> GetWithSatici(string id)
        {
            return await Entity.Include(i => i.Satici).FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}

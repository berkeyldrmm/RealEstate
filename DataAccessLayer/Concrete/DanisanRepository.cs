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
    public class DanisanRepository : GenericRepository<Danisan>, IDanisanDal
    {
        public DanisanRepository(RealEstateDBContext context) : base(context)
        {
        }
        public IQueryable<Danisan> EntityOfUser(string userId) => Entity.Where(d => d.UserId == userId);
        public async Task<IEnumerable<Danisan>> GetDanisanlarOfUser(string userId)
        {
            return await EntityOfUser(userId).ToListAsync();
        }

        public IEnumerable<Danisan> GetRange(IEnumerable<string> Ids)
        {
            return Entity.Where(danisan => Ids.Contains(danisan.Id)).ToList();
        }
    }
}

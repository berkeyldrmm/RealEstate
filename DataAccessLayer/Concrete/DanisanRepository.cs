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

        public IEnumerable<Danisan> GetRange(string userId, IEnumerable<string> Ids)
        {
            return EntityOfUser(userId).Where(danisan => Ids.Contains(danisan.Id)).ToList();
        }

        public IEnumerable<Danisan> SearchDanisan(string userId, string search)
        {
            if(search == null)
            {
                return EntityOfUser(userId).ToList();
            }
            return EntityOfUser(userId).Where(danisan => danisan.AdSoyad.Contains(search) || danisan.TelefonNo.Contains(search)).ToList();
        }


    }
}

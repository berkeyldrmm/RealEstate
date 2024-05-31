using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDanisanService : IGenericService<Danisan>
    {
        public Task<IEnumerable<Danisan>> GetDanisanlarOfUser(string userId);
        void DeleteRange(string userId, IEnumerable<string> Ids);
        public IEnumerable<Danisan> SearchDanisan(string userId, string search);
    }
}

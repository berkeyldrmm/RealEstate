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
        void DeleteRange(IEnumerable<string> Ids);
    }
}

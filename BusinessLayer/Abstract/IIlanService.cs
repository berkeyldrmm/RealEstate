using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IIlanService : IGenericService<Ilan>
    {
        public Task<IEnumerable<Ilan>> GetAllWithSatici();
        public Task<Ilan> GetWithSatici(string id);
    }
}

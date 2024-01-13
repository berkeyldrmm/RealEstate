using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IIlanDal : IGenericDal<Ilan>
    {
        public Task<IEnumerable<Ilan>> GetAllWithSatici();
        public Task<Ilan> GetWithSatici(string id);
    }
}

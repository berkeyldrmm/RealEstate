using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class IlanService : IIlanService
    {
        private readonly IIlanDal _ilanRepository;

        public IlanService(IIlanDal ilanRepository)
        {
            _ilanRepository = ilanRepository;
        }

        public bool DeleteAsync(Ilan item)
        {
            return _ilanRepository.Delete(item);
        }

        public void DeleteRange(IEnumerable<Ilan> items)
        {
            _ilanRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Ilan>> GetAll()
        {
            return _ilanRepository.ReadAll();
        }

        public Task<Ilan> GetOne(int id)
        {
            return _ilanRepository.Read(id);
        }

        public Task<bool> Insert(Ilan item)
        {
            return _ilanRepository.Insert(item);
        }

        public Task<bool> Update(Ilan item)
        {
            return _ilanRepository.Update(item);
        }
    }
}

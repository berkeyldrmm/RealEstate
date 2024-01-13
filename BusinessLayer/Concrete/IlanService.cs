using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
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

        public Task<Ilan> GetOne(string id)
        {
            return _ilanRepository.Read(id);
        }

        public async Task<bool> Insert(Ilan item)
        {
            return await _ilanRepository.Insert(item);
        }

        public Task<bool> Update(Ilan item)
        {
            return _ilanRepository.Update(item);
        }

        public async Task<IEnumerable<Ilan>> GetAllWithSatici()
        {
            return await _ilanRepository.GetAllWithSatici();
        }
        public async Task<Ilan> GetWithSatici(string id)
        {
            return await _ilanRepository.GetWithSatici(id);
        }
    }
}

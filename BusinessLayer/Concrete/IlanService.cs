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

        public void DeleteRange(IEnumerable<string> Ids)
        {
            var items = _ilanRepository.GetRange(Ids);
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

        public async Task<IEnumerable<Ilan>> GetAllWithSatici(string userId)
        {
            return await _ilanRepository.GetAllWithSatici(userId);
        }
        public async Task<Ilan> GetWithSatici(string userId, string id)
        {
            return await _ilanRepository.GetWithSatici(userId, id);
        }

        public Task<IlanTalepTipi> GetIlanTalepTipi(int id)
        {
            return _ilanRepository.GetIlanTalepTipi(id);
        }

        public Task<bool> IlanSat(string id, string kazanc)
        {
            return _ilanRepository.IlanSat(id, kazanc);
        }
    }
}

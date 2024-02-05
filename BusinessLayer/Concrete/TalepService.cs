using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TalepService : ITalepService
    {
        private readonly ITalepDal _talepRepository;

        public TalepService(ITalepDal talepRepository)
        {
            _talepRepository = talepRepository;
        }

        public bool DeleteAsync(Talep item)
        {
            return _talepRepository.Delete(item);
        }

        public void DeleteRange(IEnumerable<string> Ids)
        {
            var items = _talepRepository.GetRange(Ids);
            _talepRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Talep>> GetAll()
        {
            return _talepRepository.ReadAll();
        }

        public async Task<IEnumerable<Talep>> GetAllWithAlici(string userId)
        {
            return await _talepRepository.GetAllWithAlici(userId);
        }

        public Task<IlanTalepTipi> GetIlanTalepTipi(int id)
        {
            return _talepRepository.GetIlanTalepTipi(id);
        }

        public Task<Talep> GetOne(string id)
        {
            return _talepRepository.Read(id);
        }

        public async Task<Talep> GetWithAlici(string userId, string id)
        {
            return await _talepRepository.GetWithAlici(userId, id);
        }

        public async Task<bool> Insert(Talep item)
        {
            return await _talepRepository.Insert(item);
        }

        public Task<bool> Update(Talep item)
        {
            return _talepRepository.Update(item);
        }
    }
}

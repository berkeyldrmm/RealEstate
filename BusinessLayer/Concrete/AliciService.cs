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
    public class AliciService : IAliciService
    {
        private readonly IAliciDal _aliciRepository;

        public AliciService(IAliciDal aliciRepository)
        {
            _aliciRepository = aliciRepository;
        }

        public bool DeleteAsync(Alici item)
        {
            return _aliciRepository.Delete(item);
        }

        public void DeleteRange(IEnumerable<Alici> items)
        {
            _aliciRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Alici>> GetAll()
        {
            return _aliciRepository.ReadAll();
        }

        public Task<Alici> GetOne(string id)
        {
            return _aliciRepository.Read(id);
        }

        public async Task<bool> Insert(Alici item)
        {
            return await _aliciRepository.Insert(item);
        }

        public Task<bool> Update(Alici item)
        {
            return _aliciRepository.Update(item);
        }
    }
}

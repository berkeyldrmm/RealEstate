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

        public Task<Alici> GetOne(int id)
        {
            return _aliciRepository.Read(id);
        }

        public Task<bool> Insert(Alici item)
        {
            return _aliciRepository.Insert(item);
        }

        public Task<bool> Update(Alici item)
        {
            return _aliciRepository.Update(item);
        }
    }
}

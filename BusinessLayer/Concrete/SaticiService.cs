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
    public class SaticiService : ISaticiService
    {
        private readonly ISaticiDal _saticiRepository;

        public SaticiService(ISaticiDal saticiRepository)
        {
            _saticiRepository = saticiRepository;
        }

        public bool DeleteAsync(Satici item)
        {
            return _saticiRepository.Delete(item);
        }

        public void DeleteRange(IEnumerable<Satici> items)
        {
            _saticiRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Satici>> GetAll()
        {
            return _saticiRepository.ReadAll();
        }

        public Task<Satici> GetOne(int id)
        {
            return _saticiRepository.Read(id);
        }

        public Task<bool> Insert(Satici item)
        {
            return _saticiRepository.Insert(item);
        }

        public Task<bool> Update(Satici item)
        {
            return _saticiRepository.Update(item);
        }
    }
}

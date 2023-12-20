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

        public void DeleteRange(IEnumerable<Talep> items)
        {
            _talepRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Talep>> GetAll()
        {
            return _talepRepository.ReadAll();
        }

        public Task<Talep> GetOne(int id)
        {
            return _talepRepository.Read(id);
        }

        public Task<bool> Insert(Talep item)
        {
            return _talepRepository.Insert(item);
        }

        public Task<bool> Update(Talep item)
        {
            return _talepRepository.Update(item);
        }
    }
}

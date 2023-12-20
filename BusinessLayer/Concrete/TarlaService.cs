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
    public class TarlaService : ITarlaService
    {
        private readonly ITarlaDal _tarlaRepository;

        public TarlaService(ITarlaDal tarlaRepository)
        {
            _tarlaRepository = tarlaRepository;
        }

        public bool DeleteAsync(Tarla item)
        {
            return _tarlaRepository.Delete(item);
        }

        public void DeleteRange(IEnumerable<Tarla> items)
        {
            _tarlaRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Tarla>> GetAll()
        {
            return _tarlaRepository.ReadAll();
        }

        public Task<Tarla> GetOne(int id)
        {
            return _tarlaRepository.Read(id);
        }

        public Task<bool> Insert(Tarla item)
        {
            return _tarlaRepository.Insert(item);
        }

        public Task<bool> Update(Tarla item)
        {
            return _tarlaRepository.Update(item);
        }
    }
}

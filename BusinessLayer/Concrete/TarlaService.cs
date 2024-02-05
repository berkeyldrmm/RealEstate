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

        public Task<IEnumerable<Tarla>> GetAll()
        {
            return _tarlaRepository.ReadAll();
        }

        public Task<Tarla> GetOne(string id)
        {
            return _tarlaRepository.Read(id);
        }

        public async Task<bool> Insert(Tarla item)
        {
            return await _tarlaRepository.Insert(item);
        }

        public Task<bool> Update(Tarla item)
        {
            return _tarlaRepository.Update(item);
        }
    }
}

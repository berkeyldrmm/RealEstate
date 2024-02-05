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
    public class ArsaService : IArsaService
    {
        private readonly IArsaDal _arsaRepository;

        public ArsaService(IArsaDal arsaRepository)
        {
            _arsaRepository = arsaRepository;
        }

        public bool DeleteAsync(Arsa item)
        {
            return _arsaRepository.Delete(item);
        }


        public Task<IEnumerable<Arsa>> GetAll()
        {
            return _arsaRepository.ReadAll();
        }

        public Task<Arsa> GetOne(string id)
        {
            return _arsaRepository.Read(id);
        }

        public async Task<bool> Insert(Arsa item)
        {
            return await _arsaRepository.Insert(item);
        }

        public Task<bool> Update(Arsa item)
        {
            return _arsaRepository.Update(item);
        }
    }
}

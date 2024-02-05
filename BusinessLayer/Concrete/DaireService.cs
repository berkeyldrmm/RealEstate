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
    public class DaireService : IDaireService
    {
        private readonly IDaireDal _daireRepository;

        public DaireService(IDaireDal daireRepository)
        {
            _daireRepository = daireRepository;
        }

        public bool DeleteAsync(Daire item)
        {
            return _daireRepository.Delete(item);
        }


        public Task<IEnumerable<Daire>> GetAll()
        {
            return _daireRepository.ReadAll();
        }

        public Task<Daire> GetOne(string id)
        {
            return _daireRepository.Read(id);
        }

        public async Task<bool> Insert(Daire item)
        {
            return await _daireRepository.Insert(item);
        }

        public Task<bool> Update(Daire item)
        {
            return _daireRepository.Update(item);
        }
    }
}

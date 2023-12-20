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

        public void DeleteRange(IEnumerable<Daire> items)
        {
            _daireRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Daire>> GetAll()
        {
            return _daireRepository.ReadAll();
        }

        public Task<Daire> GetOne(int id)
        {
            return _daireRepository.Read(id);
        }

        public Task<bool> Insert(Daire item)
        {
            return _daireRepository.Insert(item);
        }

        public Task<bool> Update(Daire item)
        {
            return _daireRepository.Update(item);
        }
    }
}

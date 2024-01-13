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
    public class DukkanService : IDukkanService
    {
        private readonly IDukkanDal _dukkanRepository;

        public DukkanService(IDukkanDal dukkanRepository)
        {
            _dukkanRepository = dukkanRepository;
        }

        public bool DeleteAsync(Dukkan item)
        {
            return _dukkanRepository.Delete(item);
        }

        public void DeleteRange(IEnumerable<Dukkan> items)
        {
            _dukkanRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Dukkan>> GetAll()
        {
            return _dukkanRepository.ReadAll();
        }

        public Task<Dukkan> GetOne(string id)
        {
            return _dukkanRepository.Read(id);
        }

        public async Task<bool> Insert(Dukkan item)
        {
            return await _dukkanRepository.Insert(item);
        }

        public Task<bool> Update(Dukkan item)
        {
            return _dukkanRepository.Update(item);
        }
    }
}

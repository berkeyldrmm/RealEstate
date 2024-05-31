using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DanisanService : IDanisanService
    {
        private readonly IDanisanDal _danisanRepository;

        public DanisanService(IDanisanDal danisanRepository)
        {
            _danisanRepository = danisanRepository;
        }

        public bool DeleteAsync(Danisan item)
        {
            return _danisanRepository.Delete(item);
        }

        public void DeleteRange(string userId, IEnumerable<string> Ids)
        {
            var items = _danisanRepository.GetRange(userId, Ids);
            _danisanRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Danisan>> GetAll()
        {
            return _danisanRepository.ReadAll();
        }

        public async Task<IEnumerable<Danisan>> GetDanisanlarOfUser(string userId)
        {
            return await _danisanRepository.GetDanisanlarOfUser(userId);
        }

        public Task<Danisan> GetOne(string id)
        {
            return _danisanRepository.Read(id);
        }

        public async Task<bool> Insert(Danisan item)
        {
            return await _danisanRepository.Insert(item);
        }

        public IEnumerable<Danisan> SearchDanisan(string userId, string search)
        {
            return _danisanRepository.SearchDanisan(userId, search);
        }

        public Task<bool> Update(Danisan item)
        {
            return _danisanRepository.Update(item);
        }
    }
}

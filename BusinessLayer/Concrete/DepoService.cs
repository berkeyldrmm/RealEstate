﻿using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DepoService : IDepoService
    {
        private readonly IDepoDal _depoRepository;

        public DepoService(IDepoDal depoRepository)
        {
            _depoRepository = depoRepository;
        }

        public bool DeleteAsync(Depo item)
        {
            return _depoRepository.Delete(item);
        }

        public void DeleteRange(IEnumerable<Depo> items)
        {
            _depoRepository.DeleteRange(items);
        }

        public Task<IEnumerable<Depo>> GetAll()
        {
            return _depoRepository.ReadAll();
        }

        public Task<Depo> GetOne(int id)
        {
            return _depoRepository.Read(id);
        }

        public Task<bool> Insert(Depo item)
        {
            return _depoRepository.Insert(item);
        }

        public Task<bool> Update(Depo item)
        {
            return _depoRepository.Update(item);
        }
    }
}

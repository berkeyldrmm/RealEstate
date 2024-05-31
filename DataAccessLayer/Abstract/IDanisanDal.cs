﻿using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDanisanDal : IGenericDal<Danisan>
    {
        public Task<IEnumerable<Danisan>> GetDanisanlarOfUser(string userId);
        IEnumerable<Danisan> GetRange(string userId, IEnumerable<string> Ids);
        public IEnumerable<Danisan> SearchDanisan(string userId, string search);
    }
}

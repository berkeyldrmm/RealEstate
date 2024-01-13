﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class AliciRepository : GenericRepository<Alici>, IAliciDal
    {
        public AliciRepository(RealEstateDBContext context) : base(context)
        {
        }
    }
}

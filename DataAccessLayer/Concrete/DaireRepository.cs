﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class DaireRepository : GenericRepository<Daire>, IDaireDal
    {
        public DaireRepository(RealEstateDBContext context) : base(context)
        {
        }
    }
}

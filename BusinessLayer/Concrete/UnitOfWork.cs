using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RealEstateDBContext _context;

        public UnitOfWork(RealEstateDBContext context)
        {
            _context = context;
        }

        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}

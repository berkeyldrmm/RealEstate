﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public RealEstateDBContext _context { get; set; }
        public DbSet<T> Entity => _context.Set<T>();
        public GenericRepository(RealEstateDBContext context)
        {
            _context = context;
        }
        public bool Delete(T item)
        {
            EntityEntry<T> entityEntry = Entity.Remove(item);
            return entityEntry.State == EntityState.Deleted;
        }

        public void DeleteRange(IEnumerable<T> items)
        {
            Entity.RemoveRange(items);
        }

        public async Task<bool> Insert(T item)
        {
            EntityEntry<T> entityEntry = await Entity.AddAsync(item);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<T> Read(string id)
        {
            return await Entity.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ReadAll()
        {
            return await Entity.ToListAsync();
        }

        public async Task<bool> Update(T item)
        {
            EntityEntry<T> entityEntry = Entity.Update(item);
            return entityEntry.State == EntityState.Modified;
        }
    }
}

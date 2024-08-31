using Eldokkan.Application.Contract;
using ELDOKKAN.Context;
using ELDOKKAN.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eldokkan.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private AppDbContext context;

        public DbSet<T> dbSet;  

        public GenericRepository(AppDbContext _context)
        {
            context = _context;
            dbSet = _context.Set<T>();
        }

        public T Create(T Enitity)
        {
            return dbSet.Add(Enitity).Entity;
        }

        public void Delete(T Entity)
        {
          dbSet.Remove(Entity);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet.Select(p => p);
        }

        public T GetOne(int EntityId)
        {
            return dbSet.Find(EntityId) ;
        }

        public T Update(T Enitity)
        {
            throw new NotImplementedException();
        }
    }
}

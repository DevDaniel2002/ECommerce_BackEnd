using BackEndEcommerce.Models;
using BackEndEcommerce.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BackEndEcommerce.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly eCommerceContext context;
        private Microsoft.EntityFrameworkCore.DbSet<T> entities;

        public Repository(eCommerceContext _context)
        {
            context = _context;
            entities = context.Set<T>();
        }

        public IEnumerable<T> Get()
        {
            return entities.AsEnumerable();
        }

        public T Get(int id)
        {
            return entities.Find(keyValues: id);
        }

        public T Get(string id)
        {
            return entities.Find(keyValues: id);
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}

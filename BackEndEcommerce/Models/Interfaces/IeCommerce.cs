using System.Collections.Generic;

namespace BackEndEcommerce.Models.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T Get(int id);
        T Get(string id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

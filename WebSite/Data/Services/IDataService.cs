using System.Collections.Generic;

namespace WebSite.Data.Services
{
    public interface IDataService<T>
    {
        T GetById(int id);
        List<T> GetAll();
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebSite.Entities.Models;

namespace WebSite.Data.Services
{
    public class BaseDataService<T> : IDataService<T> where T : IdentityBase, new()
    {
        protected ObraSocialDbContext obraSocialContext;

        public BaseDataService()
        {
            obraSocialContext = new ObraSocialDbContext();
        }

        public T Create(T entity)
        {
            obraSocialContext.Set<T>().Add(entity);
            obraSocialContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            obraSocialContext.Set<T>().Attach(entity);
            obraSocialContext.Set<T>().Remove(entity);
            obraSocialContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            this.Delete(entity);
        }

        public List<T> GetAll()
        {
            return obraSocialContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return obraSocialContext.Set<T>().SingleOrDefault(o => o.Id == id);
        }

        public void Update(T entity)
        {
            obraSocialContext.Entry(entity).State = EntityState.Modified;
            obraSocialContext.SaveChanges();
        }

    }
}
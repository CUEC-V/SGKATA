using Microsoft.EntityFrameworkCore;
using SG.ENTITE;
using System;
using System.Linq;

namespace SG.DEPOT
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public SGDbContext Context { get; set; }

        public Repository(SGDbContext context)
        {
            this.Context = context;
        }

        public void Add(T entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            Context.Set<T>().AddRange(entity);
            Context.SaveChanges();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T FindById(string id)
        {
            return Context.Set<T>().Where(a => a.Id == id).FirstOrDefault();
        }

        public int Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return Context.SaveChanges();
        }
    }
}

using SG.ENTITY;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SG.REPOSITORY
{
    public interface IRepository<T> where T : EntityBase
    {
        void Add(T entity);
        T FindById(string id);
        int Update(T entity);
        int Delete(T entity);
    }
}

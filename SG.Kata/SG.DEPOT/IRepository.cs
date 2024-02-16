using SG.ENTITE;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SG.DEPOT
{
    public interface IRepository<T> where T : EntityBase
    {
        //  List<T> GetAll();
        void Add(T entity);
        T FindById(string id);
        int Update(T entity);
        int Delete(T entity);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenericService<T> where T :class
    {
        void InsertT(T entity);
        void UpdateT(T entity);
        void DeleteT(T entity);
        IQueryable<T> GetListAll();
        T GetById(int id);
    }
}

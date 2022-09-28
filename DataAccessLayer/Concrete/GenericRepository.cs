using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
       

        public void Delete(T entity)
        {
            using var context =new  CoreContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new CoreContext();
            return context.Set<T>().Find(id);
        }

        //public IQueryable<T> GetListAll()
        //{
        //    using var context = new CoreContext();
        //    return context.Set<T>().ToList().AsQueryable();
        //}

        public IQueryable<T> GetListAll(Expression<Func<T, bool>> filter=null)
        {
            using var context = new CoreContext();
            if (filter==null)
            {
                return context.Set<T>().ToList().AsQueryable(); 
            }

            else
            {
                return context.Set<T>().Where(filter).ToList().AsQueryable();
            }
        }

        public void Insert(T entity)
        {

            using var context = new CoreContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {

            using var context = new CoreContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}

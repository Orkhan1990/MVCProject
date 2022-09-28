using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IGenericService<Blog>,IBlogService
    {
        private readonly IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void DeleteT(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public IList<Blog> GetAllBlogByWriter(int id)
        {
            return _blogDal.GetListAll(p => p.WriterId == id).OrderByDescending(p => p.BlogCreateDate.Year).Take(3).ToList();
        }

        public IList<Blog> GetAllBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(p => p.WriterId == id).ToList();
        }

        public IList<Blog> GetAllBlogsWithCategory()
        {
            return _blogDal.GetAllListWithCategory().ToList();
        }

        public IList<Blog> GetAllBlogWithCategoryByWriter(int id)
        {
            return _blogDal.GetAllListWithCategory().Where(p => p.WriterId == id).ToList();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public IQueryable<Blog> GetListAll()
        {
            return _blogDal.GetListAll();
        }

        public void InsertT(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void UpdateT(Blog entity)
        {
            _blogDal.Update(entity);
        }
    }
}

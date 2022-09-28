using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework

{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public IQueryable<Blog> GetAllListWithCategory()
        {
            using var context = new CoreContext();
            var entities = context.Blogs.Include(p => p.Category).ToList().AsQueryable();
            return entities;
        }
    }
}

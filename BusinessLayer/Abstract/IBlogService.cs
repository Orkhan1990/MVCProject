using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        IList<Blog> GetAllBlogsWithCategory();
        IList<Blog> GetAllBlogByWriter(int id);
        IList<Blog> GetAllBlogListByWriter(int id);
        IList<Blog> GetAllBlogWithCategoryByWriter(int id);
    }
}

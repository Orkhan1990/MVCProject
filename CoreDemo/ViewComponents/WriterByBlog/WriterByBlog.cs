using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.WriterByBlog
{
    public class WriterByBlog:ViewComponent
    {
        private readonly IBlogService _blogServices;
        public WriterByBlog(IBlogService blogServices)
        {
            _blogServices = blogServices;
        }
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.i = id;
            var value = _blogServices.GetAllBlogByWriter(id);
            return View(value);
        }
    }
}

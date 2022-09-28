using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Dashboard
{
    public class BlogListDashboard:ViewComponent
    {
        private readonly IBlogService _blogService;
        public BlogListDashboard(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _blogService.GetAllBlogsWithCategory();
            return View(values);
        }
    }
}

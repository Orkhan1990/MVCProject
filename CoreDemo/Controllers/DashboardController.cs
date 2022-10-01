using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategorService _categorService;
        public DashboardController(IBlogService blogService,ICategorService categorService)
        {
            _blogService = blogService;
            _categorService = categorService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.blogCount = _blogService.GetListAll().Count();
            ViewBag.allBlogByWriter = _blogService.GetAllBlogByWriter(1).Count();
            ViewBag.categoryCount = _categorService.GetListAll().Count();
            return View();
        }
    }
}

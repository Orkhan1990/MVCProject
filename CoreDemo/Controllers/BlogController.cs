using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntitiesLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategorService _categoryService;
        public BlogController(IBlogService blogService,ICategorService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }

         [AllowAnonymous]
        public IActionResult Index()
        {
            var values = _blogService.GetAllBlogsWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.i = id;
            var value = _blogService.GetById(id);
            return View(value);
        }

        public IActionResult BlogListByWriter()
        {
            var values = _blogService.GetAllBlogWithCategoryByWriter(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> categoryValues = GetListItemCategory();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterId = 1;
                _blogService.InsertT(blog);
                return RedirectToAction("BlogListByWriter", "Blog");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var findedValues = _blogService.GetById(id);
            if (findedValues == null)
            {
                throw new ArgumentNullException("Deyer sifir oldugu ucun");
            }

            _blogService.DeleteT(findedValues);
                return RedirectToAction("BlogListByWriter");
            
           
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = _blogService.GetById(id);
            if (blogValue==null)
            {
                throw new ArgumentNullException();
            }
            List<SelectListItem> categoryValues = GetListItemCategory();
            ViewBag.cv = categoryValues;
            return View(blogValue);
        }

        [HttpPost]

        public IActionResult EditBlog(Blog blog)
        {
            blog.WriterId = 2;
            blog.BlogStatus = true;
            blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _blogService.UpdateT(blog);
            return RedirectToAction("BlogListByWriter");
        }


        public  List<SelectListItem> GetListItemCategory()
        {
          return  (from c in _categoryService.GetListAll()
             select new SelectListItem
             {
                 Text = c.CategoryName,
                 Value = c.CategoryID.ToString()
             }).ToList();
        }
    }

   
}

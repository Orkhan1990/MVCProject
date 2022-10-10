using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntitiesLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategorService _categoryService;
        public CategoryController(ICategorService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index(int page=1)
        {

            var values = _categoryService.GetListAll().ToPagedList(page,3);
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var deletedValu = _categoryService.GetById(id);
            _categoryService.DeleteT(deletedValu);
            return RedirectToAction("Index","Category");
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category entity)
        {
            CategoryValidation cv = new CategoryValidation();
            ValidationResult result = cv.Validate(entity);
            if (result.IsValid)
            {
                _categoryService.InsertT(entity);
                return RedirectToAction("Index", "Category");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View("Index");
        }
    }
}

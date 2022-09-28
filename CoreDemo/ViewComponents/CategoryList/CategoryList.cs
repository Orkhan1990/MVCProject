using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.CategoryList
{
    public class CategoryList:ViewComponent
    {
        private readonly ICategorService _categorService;
        public CategoryList(ICategorService categorService)
        {
            _categorService = categorService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _categorService.GetListAll();
            return View(values);
        }
    }
}

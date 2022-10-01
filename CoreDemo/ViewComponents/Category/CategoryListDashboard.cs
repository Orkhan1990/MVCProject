using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Dashboard
{
    public class CategoryListDashboard:ViewComponent
    {
        private readonly ICategorService _categorService;
        public CategoryListDashboard(ICategorService categorService)
        {
            _categorService = categorService;
        }
        public IViewComponentResult Invoke()
        {
            IQueryable<Category> values = _categorService.GetListAll();
            return View(values);
        }
    }
}

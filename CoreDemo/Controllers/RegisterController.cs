using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntitiesLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IWriterService _writerService;
        public RegisterController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer entity)
        {

            WriterValidation wv = new WriterValidation();
            ValidationResult result = wv.Validate(entity);
            if (result.IsValid)
            {
                entity.WriterStatus = true;
                entity.WriterAbout = "haqqimizda";
                _writerService.InsertT(entity);
                return RedirectToAction("Index", "Login");
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
    }
}

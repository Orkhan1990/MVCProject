using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using CoreDemo.Models.Writer;
using EntitiesLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService;
        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult EditWriterProfile()
        {
            var value = _writerService.GetById(1);
            return View(value);
        }

        [AllowAnonymous]
        [HttpPost]

        public IActionResult EditWriterProfile(Writer writer)
        {
            WriterValidation validation = new WriterValidation();
            ValidationResult result = validation.Validate(writer);
            if (result.IsValid)
            {
                _writerService.UpdateT(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorCode);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWriter(AddWriterImage entity)
        {
            Writer newWriter = new Writer(); 
            if (entity.WriterImage!=null)
            {

                var extension = Path.GetExtension(entity.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterProfileImage/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                entity.WriterImage.CopyTo(stream);
                newWriter.WriterImage = newImageName;
            }
            newWriter.WriterName = entity.WriterName;
            newWriter.WriterAbout = entity.WriterAbout;
            newWriter.WriterStatus = true;
            newWriter.EmailAddress = entity.EmailAddress;
            newWriter.Password = entity.Password;
            _writerService.InsertT(newWriter);
            return RedirectToAction("Index","Dashboard");
        }
    }
}

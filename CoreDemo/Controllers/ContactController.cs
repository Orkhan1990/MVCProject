using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact entity)
        {
            entity.ContactDate =DateTime.Parse(DateTime.Now.ToShortDateString());
            entity.ContactStatus = true;
            _contactService.InsertT(entity);
            return RedirectToAction("Index","Blog");
        } 
    }
}

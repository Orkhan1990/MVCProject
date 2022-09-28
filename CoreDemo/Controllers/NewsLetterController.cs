using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        private readonly INewsLetterService _newsLetterService;
        public NewsLetterController(INewsLetterService newsLetterService)
        {
            _newsLetterService = newsLetterService;
        }
        [HttpGet]
        public PartialViewResult SubscribeEmail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeEmail(NewsLetter entity)
        {
            entity.Status = true;
            _newsLetterService.InsertT(entity);
            return PartialView();
        }
    }
}

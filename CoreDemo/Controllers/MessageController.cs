using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
       
        [AllowAnonymous]
        public IActionResult Inbox()
        {
            int id = 1;
            var values = _messageService.GetMessageFromSender(id);
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var value = _messageService.GetById(id);
           
            return View(value);
        }
    }
}

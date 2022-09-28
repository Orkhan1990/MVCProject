using DataAccessLayer.Context;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
       
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


       
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer entity)
        {

            CoreContext context = new CoreContext();
            var dataValue = context.Writers.
                FirstOrDefault(p => p.EmailAddress == entity.EmailAddress && p.Password == entity.Password);
            if (dataValue!=null)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Email,entity.EmailAddress)
                };
                var userIdentity = new ClaimsIdentity(claims,"a");
                var principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Blog");
            }
            else
            {
                return View();
            }

           
        }
    }
}

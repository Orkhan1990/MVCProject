using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddComment(Comment entity)
        {
            entity.CommentDate =DateTime.Parse(DateTime.Now.ToShortDateString());
            entity.CommentStatus = true;
            entity.BlogID = 2;
            _commentService.InsertT(entity);
            return PartialView();
        }
    }
}

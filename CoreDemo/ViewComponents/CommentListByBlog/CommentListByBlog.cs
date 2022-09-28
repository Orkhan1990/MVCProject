using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.CommentListByBlog
{
    public class CommentListByBlog:ViewComponent
    {
        private readonly ICommentService _commentService;
        public CommentListByBlog(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.GetAllCommentByBlogId(id);
            return View(values);
        }
    }
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void DeleteT(Comment entity)
        {
            throw new NotImplementedException();
        }

        public IList<Comment> GetAllCommentByBlogId(int id)
        {
            return _commentDal.GetListAll(p => p.BlogID == id).ToList();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void InsertT(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void UpdateT(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}

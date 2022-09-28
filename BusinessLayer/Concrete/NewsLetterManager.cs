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
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterDal _newsLetterDal;
        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }
        public void DeleteT(NewsLetter entity)
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NewsLetter> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void InsertT(NewsLetter entity)
        {
            _newsLetterDal.Insert(entity);
        }

        public void UpdateT(NewsLetter entity)
        {
            throw new NotImplementedException();
        }
    }
}

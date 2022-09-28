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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void DeleteT(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void InsertT(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void UpdateT(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}

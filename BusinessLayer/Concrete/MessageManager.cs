using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void DeleteT(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public IQueryable<Message> GetListAll()
        {
            return _messageDal.GetListAll();
        }


        public void InsertT(Message entity)
        {
            _messageDal.Insert(entity);
        }

        public void UpdateT(Message entity)
        {
            _messageDal.Update(entity);
        }

        IList<Message> IMessageService.GetMessageFromSender(int id)
        {
            return _messageDal.GetListSenderMessage(id);
        }
    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message>, IMessageDal
    {
        public IList<Message> GetListSenderMessage(int id)
        {
            using var context = new CoreContext();
            return context.Messages.Include(p => p.Sender).Where(p => p.SenderId == id).ToList();
        }
    }
}

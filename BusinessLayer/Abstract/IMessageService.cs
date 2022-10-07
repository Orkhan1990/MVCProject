using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IMessageService:IGenericService<Message>
    {
        IList<Message> GetMessageFromSender(int id);
    }
}

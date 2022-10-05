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
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;
        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }
        public void DeleteT(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        public Notification GetById(int id)
        {
            var notification = _notificationDal.GetById(id);
            return notification;
        }

        public IQueryable<Notification> GetListAll()
        {
            return _notificationDal.GetListAll();
        }

        public void InsertT(Notification entity)
        {
            _notificationDal.Insert(entity);
        }

        public void UpdateT(Notification entity)
        {
            _notificationDal.Update(entity);
        }
    }
}

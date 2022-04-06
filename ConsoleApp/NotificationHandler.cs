using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class NotificationHandler
    {
        private readonly INotification[] notifications;
        private int index = 0;
        public NotificationHandler(int size)
        {
            notifications = new INotification[size];
        }

        public void Add(INotification notification)
        {
            notifications[index] = notification;
            index++;
        }

        public INotification[] GetNotifications()
        {
            return notifications;
        }
    }
}

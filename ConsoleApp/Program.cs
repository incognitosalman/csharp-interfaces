// See https://aka.ms/new-console-template for more information
using Models;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            NotificationHandler notificationHandler = new NotificationHandler(100);

            notificationHandler.Add(new EmailNotification());
            notificationHandler.Add(new SmsNotification());


            var notifications = notificationHandler.GetNotifications();

            for (int i = 0; i < notifications.Length; i++)
            {
                if (notifications[i] != null)
                    notifications[i].Notify($"Hello {i + 1}");
            }
        }
    }
}

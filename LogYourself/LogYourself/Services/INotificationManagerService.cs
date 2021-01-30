using LogYourself.Models;
using System;

namespace LogYourself.Services
{
    interface INotificationManagerService
    {
        void RemoveNotification(NotificationModel model);
        void AddOrUpdateNotification(NotificationModel model);
    }
}
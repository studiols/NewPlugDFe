using PlugDFe.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace PlugDFe.Domain.Services
{
    public abstract class Notifiable<T> where T : Notification
    {
        private readonly List<T> _notifications;

        protected Notifiable() => _notifications = new List<T>();

        private T GetNotificationInstance(string key, string message)
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { key, message });
        }

        public IReadOnlyCollection<T> Notifications => _notifications;

        public void AddNotification(string key, string message)
        {
            var notification = GetNotificationInstance(key, message);
            _notifications.Add(notification);
        }
    }
}

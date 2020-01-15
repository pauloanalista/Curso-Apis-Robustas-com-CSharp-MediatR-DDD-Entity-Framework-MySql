using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace VemDeZap.Domain.Commands
{
    public class Response
    {
        public Response(INotifiable notifiable)
        {
            this.Success = notifiable.IsValid();
            this.Notifications = notifiable.Notifications;
        }

        public Response(INotifiable notifiable, object data)
        {
            this.Success = notifiable.IsValid();
            this.Data = data;
            this.Notifications = notifiable.Notifications;
        }

        public IEnumerable<Notification> Notifications { get; }
        public bool Success { get; private set; }
        public object Data { get; private set; }

        //public void SetResult<TData>(TData data) where TData : class;
        //public void SetResult(object data);
    }
}

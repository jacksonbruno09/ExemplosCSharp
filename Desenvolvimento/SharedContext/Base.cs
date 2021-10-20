using System;
using Desenvolvimento.NotificationContext;

namespace Desenvolvimento.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
             Id = new Guid(); //SPOFF
        }
         public Guid Id { get; set; }

    }

}
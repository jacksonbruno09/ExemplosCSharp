using System;
using System.Collections.Generic;
using System.Linq;
using Desenvolvimento.SharedContext;
using Desenvolvimento.NotificationContext;

namespace Desenvolvimento.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (isPremium)
            {
                AddNotification(new Notification("Premium", "O Aluno ja tem Assinatura Ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }


        public bool isPremium => Subscriptions.Any(x => !x.IsInactive);


    }


}
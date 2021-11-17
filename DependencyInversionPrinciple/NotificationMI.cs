using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class NotificationMI
    {
        public string Text { get; set; }
        public void DoNotify(IMessenger messenger)
        {
            messenger.SendMessage(Text);
        }
    }
}

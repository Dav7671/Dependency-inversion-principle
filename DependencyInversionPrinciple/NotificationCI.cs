using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{

    //Constructor Injection
    public class NotificationCI
    {
        private IMessenger _iMessenger;
        public string Text { get; set; }
        public NotificationCI(IMessenger messenger)
        {
            _iMessenger = messenger;
        }
        public void DoNotify()
        {
            _iMessenger.SendMessage(Text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class NotificationPI
    {
        private IMessenger _iMessenger;
        public string Text { get; set; }
        public NotificationPI()
        {
        }
        public IMessenger MessageService
        {
            private get
            {
                return _iMessenger;
            }
            set
            {
                _iMessenger = value;
            }
        }

        public void DoNotify()
        {
            _iMessenger.SendMessage(Text);
        }
    }
}
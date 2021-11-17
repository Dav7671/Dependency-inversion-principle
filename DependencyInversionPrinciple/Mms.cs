﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Mms : IMessenger
    {
        public void SendMessage(string text)
        {
            Console.WriteLine($"MMS : {text}");
        }
    }
}
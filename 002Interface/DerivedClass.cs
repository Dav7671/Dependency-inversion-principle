using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002Interface
{
    class DerivedClass : Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Realising Method1 from Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Realising Method2 from Interface2");
        }
    }
}

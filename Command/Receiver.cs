using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("I executed your command and...");
            Console.WriteLine("Cooked the dinner :)");
            Console.WriteLine("Help yourself!");
        }
    }
}

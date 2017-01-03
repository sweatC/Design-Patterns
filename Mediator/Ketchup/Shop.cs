using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetchupMediator
{
    class Shop : Colleague
    {
        public Shop(Mediator m) : base(m)
        {
        }

        public void SellKetchup(string msg)
        {
            Console.WriteLine(this.GetType().Name + " sell " + msg);
        }
    }
}

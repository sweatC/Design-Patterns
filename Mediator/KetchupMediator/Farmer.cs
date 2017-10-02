using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KetchupMediator
{
    class Farmer : Colleague
    {
        public Farmer(Mediator m) : base(m)
        {
        }

        public void GrowTomato()
        {
            string tomato = "tomato";
            Thread.Sleep(500);
            Console.WriteLine(this.GetType().Name + " growed " + tomato);

            mediator.Send(tomato, this);
        }
    }
}

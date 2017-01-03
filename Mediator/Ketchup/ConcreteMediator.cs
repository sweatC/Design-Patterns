using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetchupMediator
{
    class ConcreteMediator : Mediator
    {
        public Farmer Farmer { get; set; }
        public Cannery Cannery { get; set; }
        public Shop Shop { get; set; }

        public override void Send(string msg, Colleague col)
        {
            if (col == Farmer)
                Cannery.MakeKetchup(msg);
            else if(col == Cannery)
                Shop.SellKetchup(msg);
        }
    }
}

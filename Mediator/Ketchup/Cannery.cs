﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KetchupMediator
{
    class Cannery : Colleague
    {
        public Cannery(Mediator m) : base(m)
        {
        }

        public void MakeKetchup(string msg)
        {
            string ketchup = msg + " ketchup";
            Thread.Sleep(1000);
            Console.WriteLine(this.GetType().Name + " produced " + ketchup);

            mediator.Send(ketchup, this);
        }
    }
}

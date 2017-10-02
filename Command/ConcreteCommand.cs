﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver r) : base(r)
        {
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}

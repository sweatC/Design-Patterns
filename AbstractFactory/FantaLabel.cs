using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FantaLabel : AbstractLabel
    {
        public override void Interact(AbstractBottle bottle)
        {
            Console.WriteLine(this + " interact with " + bottle);
        }
    }
}

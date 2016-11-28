using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        AbstractBottle bottle;
        AbstractWater water;

        public Client(AbstractFactory factory)
        {
            bottle = factory.CreateBottle();
            water = factory.CreateWater();
        }

        public void Run()
        {
            bottle.Interact(water);
        }
    }
}

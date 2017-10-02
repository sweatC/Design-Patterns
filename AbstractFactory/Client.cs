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
        AbstractCover cover;
        AbstractLabel label;

        public Client(AbstractFactory factory)
        {
            bottle = factory.CreateBottle();
            water = factory.CreateWater();
            cover = factory.CreateCover();
            label = factory.CreateLabel();
        }

        public void Run()
        {
            bottle.Interact(water);
            cover.Interact(bottle);
            label.Interact(bottle);
        }
    }
}

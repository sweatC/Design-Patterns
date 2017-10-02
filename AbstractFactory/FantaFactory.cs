using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FantaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new FantaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new FantaCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new FantaLabel();
        }

        public override AbstractWater CreateWater()
        {
            return new FantaWater();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }
    }
}

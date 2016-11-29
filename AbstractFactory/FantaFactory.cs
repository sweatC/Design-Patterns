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
            throw new NotImplementedException();
        }

        public override AbstractCover CreateCover()
        {
            throw new NotImplementedException();
        }

        public override AbstractWater CreateWater()
        {
            throw new NotImplementedException();
        }
    }
}

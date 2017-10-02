using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        public void Construct(Builder b)
        {
            b.BuildBottle();
            b.BuildWater();
            b.BuildCover();
            b.BuildLabel();
        }
    }
}

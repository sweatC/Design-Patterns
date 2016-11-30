using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class Builder
    {
        public abstract void BuildBottle();
        public abstract void BuildWater();
        public abstract void BuildCover();
        public abstract void BuildLabel();
    }
}

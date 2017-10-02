using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CocaColaBuilder : Builder
    {
        Product product = new Product();

        public override void BuildBottle()
        {
            Console.WriteLine("Bottle was built");
        }

        public override void BuildCover()
        {
            Console.WriteLine("Cover was built");
        }

        public override void BuildLabel()
        {
            Console.WriteLine("Label was built");
        }

        public override void BuildWater()
        {
            Console.WriteLine("Water was built");
        }

        public override Product GetResult()
        {
            product.Add(new CocaColaBottle());
            product.Add(new CocaColaWater());
            product.Add(new CocaColaCover());
            product.Add(new CocaColaLabel());

            return product; 
        }
    }
}

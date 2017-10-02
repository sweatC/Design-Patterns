using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new CocaColaBuilder();
            Director director = new Director();
            Product product = builder.GetResult();
            director.Construct(builder);
            product.Show();
        }
    }
}

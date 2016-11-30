using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Product
    {
        ArrayList products = new ArrayList();

        public void Add(object part)
        {
            products.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Our product contains: ");
            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

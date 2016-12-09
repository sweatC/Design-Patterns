using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Prototype proto = new ConcretePrototype(5);
                Prototype clone = proto.Clone(5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Ooooops");
            }
        }
    }
}

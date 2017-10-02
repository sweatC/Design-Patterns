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

            Prototype p = new ConcretePrototype(0);

            var Hug = p.Clone(1);

            var Kiss = Hug.Clone(2);

            var Sex = Kiss.Clone(3);

            var Wedding = Sex.Clone(4);

            var Family = Wedding.Clone(5);

            Dictionary<Prototype, string> protos =  new Dictionary<Prototype, string>
            {
                { Hug, "Hug" },
                { Kiss, "Kiss" },
                { Sex, "Sex" },
                { Wedding, "Wedding" },
                { Family, "Family" }
            };

            foreach (var prot in protos)
            {
                Console.WriteLine(prot.Value + " " +  prot.Key.Id);
            }
        }
    }
}

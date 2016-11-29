using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new CocaColaFactory());
            client.Run();
            client = new Client(new FantaFactory());
            client.Run();
        }
    }
}

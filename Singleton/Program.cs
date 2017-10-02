using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void m()
        {
            Singleton s = Singleton.Instance();
            s.Name = "LOL";
            Console.WriteLine(s.Name);
            Thread.Sleep(700);
            Console.WriteLine(s.GetHashCode());
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(m));
            Singleton my = Singleton.Instance();

            my.Name = "John";
            Console.WriteLine(my.Name);
            Console.WriteLine(my.GetHashCode());
            thread.Start();
            thread.Join();
            Singleton my2 = Singleton.Instance();
            Console.WriteLine(my2.Name);
            Console.WriteLine(my2.GetHashCode());
        }
    }
}

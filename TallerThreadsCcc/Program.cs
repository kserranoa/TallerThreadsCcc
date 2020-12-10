using System;
using System.Threading;
using System.Text;
using System.Collections.Concurrent;
using System.Linq;

namespace TallerThreadsCcc
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hilo = new Thread(metodo);
            hilo.Start();
            for (int i = 0; i < 1000; i++)
                Console.Write("x");
            Console.Read();
        }
        static void metodo()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("y");
        }
    }
}

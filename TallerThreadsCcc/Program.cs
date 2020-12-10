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
            Random aleatorioSemilla = new Random();
            int[,] matriss = new int[10, 10];
            int lugarX = aleatorioSemilla.Next(1, 1);
            int lugarY = aleatorioSemilla.Next(1, 11);
            Thread usuarios = new Thread(usuario);
            usuarios.Start();                        
            semilla(matriss, lugarX, lugarY);
            //semillas.Start();            
            Thread serpienteUno = new Thread(serpiente);
            serpienteUno.Start();            
        }
        //public int[,]
        public static void semilla(int[,] matriss, int lugarX, int lugarY)
        {
            matriss[lugarX, lugarY] = 1;         

        }
        static void serpiente()
        {
            Console.Write("y");
        }
        static void usuario()
        {
            Console.Write("y");
        }
    }
}

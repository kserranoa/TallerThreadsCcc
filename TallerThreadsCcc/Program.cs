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
            int lugarX = aleatorioSemilla.Next(1, 11);
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
            //While forever
                //if ver NO si hay un 1 (semilla)
                matriss[lugarX, lugarY] = 1;  
                //Esperar 10 segundos

        }
        static void serpiente()
        {
            Console.Write("y");
            //While si no hay usuario (3) DETENER TODO
            //if ver NO si hay un 2 (serpiente)
            //matriss[lugarX, lugarY] = 2;
            //si hay semilla Esperar 20 segundos
            //sino hay semilla esperar 10

        }
        static void usuario()
        {
            //While forever
            //Perdir dos numeros entre 1 a 10 al usuario
            //Ir al vector que ingreso el usuario 3(user) y
            //borrar el 3(usuario) del vector anterior del user
            //si hay semilla Esperar 10 segundos
            //sino hay semilla esperar 5
            Console.Write("y");
        }
    }
}

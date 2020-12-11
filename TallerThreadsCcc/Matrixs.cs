using System;
using System.Collections.Generic;
using System.Text;

namespace TallerThreadsCcc
{
    class Matrixs
    {
        public static int[,] matriss = new int[10, 10];
        //Random azarX = new Random();
        //int lugarX;
        public static int NumeroAzarX()
        {
            Random azarX = new Random();
            int lugarX;
            lugarX = azarX.Next(1, 11);
            return lugarX;
        }

        public static int NumeroAzarY()
        {
            Random azarY = new Random();
            int lugarY;
            lugarY = azarY.Next(1, 11);
            return lugarY;
        }
        public static void CrearMatrixs()
        {               
            Console.WriteLine("Creo matrix");
        }
        public static void AddVectores(int[,] matriss, int lugarX, int lugarY)
        {
            //NumeroAzarY();
            //NumeroAzarY();
            matriss[lugarX, lugarY] = 1;
        }
    }
}

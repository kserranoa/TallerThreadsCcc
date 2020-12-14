using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace pruebas
{
    class Matrixs
    {
        public static int[,] matriss = new int[10, 10];

        public static int NumAle()
        {
            Random aleatorioN = new Random();
            int X = aleatorioN.Next(1, 11);
            return X;
        }
    }
}

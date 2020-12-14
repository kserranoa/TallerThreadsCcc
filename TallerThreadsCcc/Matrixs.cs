using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace TallerThreadsCcc
{
    class Matrixs // clase Matrix para tablero del juego
    {
        public static int[,] matriss = new int[10, 10]; // matriz de 10x10 que es el tablero del juego donde se ubican semillas/ serpiente

        public static int NumAle() // metodo NumAle que permite generar numero random
        {
            Random aleatorioN = new Random(); // objeto de tipo random
            int X = aleatorioN.Next(1, 11); // genera num random entre 1 y 10 guarda en X
            return X;
        }
    }
}

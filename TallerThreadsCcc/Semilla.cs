using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace TallerThreadsCcc
{
    class Semilla // clase que crea semilla en juego
    {
        public static int Semill = 1; // semilla es num 1 

        public static void InsertVectorSemilla () // metodo de insertar semilla en vector de juego
        {
            while (Serpiente.Fin == 0) // ciclo while para que corra semilla
            {
                int Xsemi = Matrixs.NumAle(); // almacena ubicacion en X
                int Ysemi = Matrixs.NumAle(); // almacena ubicacion en Y

                if (Matrixs.matriss[Xsemi, Ysemi] == Semill) // si la ubicacion de semilla en ejes x y y es igual a semilla
                {                    
                    Matrixs.matriss[Xsemi, Ysemi] = Semill;
                    Thread.Sleep(10000); //ejecuta pausa del hilo de 10segundos
                }
            }
        }

    }
}

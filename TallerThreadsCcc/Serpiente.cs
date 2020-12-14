using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace TallerThreadsCcc
{
    class Serpiente // Clase para crear serpiente
    {
        public static int Serpi = 3; // el num de la serpiente es 3
        public static int SemillaSerpi; // almacena la semilla de la serpiente
        public static int Fin = 10; // muestra el fin 

        public static void InsertVectorSerpi() // metodo para ingresar serpiente en juego
        {
            int Xserpi = Matrixs.NumAle(); // guarda posicion en X de serpiente
            int Yserpi = Matrixs.NumAle(); // guarda posicion en Y de serpiente

            while (Matrixs.matriss[Xserpi, Yserpi] != Usuario.User) // ciclo while para correr juego
            {
                if (Matrixs.matriss[Xserpi, Yserpi] == Semilla.Semill) //si la ubicacion de serpiente es igual a la de una semilla
                {
                    SemillaSerpi += 1; // sumele uno a serpiente porque comio una semilla
                    Matrixs.matriss[Xserpi, Yserpi] = Serpi; // ubica a la serpiente
                    Thread.Sleep(10000); // hace una pausa del hilo para que serpiente coma semilla 10 segs
                }
                Matrixs.matriss[Xserpi, Yserpi] = 0; //ubica a serpiente
                Thread.Sleep(10000); // hilo de pausa de 10 segs
                Xserpi = Matrixs.NumAle(); // pone ubicacion en X
                Yserpi = Matrixs.NumAle(); // pone ubicacion en Y
            }
            Fin = 0; // muestra el fin
        }
    }
}

// Clase para crear el usuario del juego

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace TallerThreadsCcc
{
    class Usuario // clase crea usuario
    {
        public static int User = 2; // usuario es el num 2 
        public static int SemillaUser; // variable almacena semilla del usuario
        public static void InsertVectorUser() // metodo insertar semilla del usuario en juego
        {
            int Xuser = 0; // posicion en eje x para la semilla en juego
            int Yuser = 0; // posicion en eje y para la semilla en juego
            while (Matrixs.matriss[Xuser, Yuser] != Serpiente.Serpi) // ciclo while para que siga jugando siempre que tenga posicion diferente a serpiente
            {
                Console.WriteLine("Ingrese ubicacion X: "); //Muestra en consola mensaje para solicitar ubicacion en X
                Xuser = int.Parse(Console.ReadLine()); //guarda en Xuser la posicion en X
                Console.WriteLine("Ingrese ubicacion Y: "); // Muestra en consola mensaje para solicitar ubicacion en Y
                Yuser = int.Parse(Console.ReadLine()); // guarda en variable Yuser la posicion en Y

                // condiciones if para ubicar semillas de usuario
                if (Matrixs.matriss[Xuser, Yuser] == Semilla.Semill) //si la posicion del usuario es la misma que la de semilla
                {
                    SemillaUser += 1; // se comio una semilla entonces le suma 1 
                    Matrixs.matriss[Xuser, Yuser] = User;  
                    //Sleep 10
                    Thread.Sleep(5000); // tiempo de espera del hilo mientras usuario come semilla
                }
                else if (Matrixs.matriss[Xuser, Yuser] == Serpiente.Serpi) // si ubicacion usuario es igual a ubicacion de una serpiente
                { 
                    Console.WriteLine("Detener"); // muestra mensaje de detener
                }
                Matrixs.matriss[Xuser, Yuser] = User; //en esa ubicacion se pone el usuario
                Thread.Sleep(5000); // pausa de 5 segundos del hilo
                //Sleep 5
                Matrixs.matriss[Xuser, Yuser] = 0; // pone en esa ubicacion al usuario 
            }
        }        
    }
}

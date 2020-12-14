using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace pruebas
{
    class Usuario
    {
        public static int User = 2;
        public static int SemillaUser;
        public static void InsertVectorUser()
        {
            int Xuser = 0;
            int Yuser = 0;
            while (Matrixs.matriss[Xuser, Yuser] != Serpiente.Serpi)
            {
                Console.WriteLine("Ingrese ubicacion X: ");
                Xuser = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese ubicacion Y: ");
                Yuser = int.Parse(Console.ReadLine());

                if (Matrixs.matriss[Xuser, Yuser] == Semilla.Semill)
                {
                    SemillaUser += 1;
                    Matrixs.matriss[Xuser, Yuser] = User;
                    //Sleep 10
                    Thread.Sleep(10000);
                }
                else if (Matrixs.matriss[Xuser, Yuser] == Serpiente.Serpi)
                {
                    Console.WriteLine("Detener");
                }
                Matrixs.matriss[Xuser, Yuser] = User;
                Thread.Sleep(10000);
                Console.WriteLine(Matrixs.matriss[Xuser, Yuser]);
                //Sleep 5
                Matrixs.matriss[Xuser, Yuser] = 0;
            }
        }        
    }
}

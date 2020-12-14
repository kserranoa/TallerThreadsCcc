using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace pruebas
{
    class Serpiente
    {
        public static int Serpi = 3;
        public static int SemillaSerpi;
        public static int Fin = 10;

        public static void InsertVectorSerpi()
        {
            int Xserpi = Matrixs.NumAle();
            int Yserpi = Matrixs.NumAle();

            while (Matrixs.matriss[Xserpi, Yserpi] != Usuario.User)
            {
                if (Matrixs.matriss[Xserpi, Yserpi] == Semilla.Semill)
                {
                    SemillaSerpi += 1;
                    Matrixs.matriss[Xserpi, Yserpi] = Serpi;
                    //Sleep 10
                }
                Matrixs.matriss[Xserpi, Yserpi] = 0;
                //
            }
            Fin = 0;
        }
    }
}

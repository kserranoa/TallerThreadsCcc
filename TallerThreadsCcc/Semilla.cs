using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace pruebas
{
    class Semilla
    {
        public static int Semill = 1;

        public static void InsertVectorSemilla ()
        {
            while (Serpiente.Fin == 0)
            {
                int Xsemi = Matrixs.NumAle();
                int Ysemi = Matrixs.NumAle();

                if (Matrixs.matriss[Xsemi, Ysemi] == Semill)
                {                    
                    Matrixs.matriss[Xsemi, Ysemi] = Semill;
                    //Sleep 10
                }
            }
        }

    }
}

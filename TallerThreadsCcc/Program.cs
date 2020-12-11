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
            //Creo matrixs
            Matrixs.crearMatrixs();
            //Crea hilo de usuario
            ThreadStart semillas = new ThreadStart(ClassSemilla.selectVsemilla);
            Thread hiloSemilla = new Thread(semillas);
            hiloSemilla.Start(); 

            //Crea hilo para colocar hilos
            //Thread semillas = new Thread(ClassSemilla.selectVsemilla());
            //semillas.Start(); 

            ////Crea hilo para manipular las cuatro serpientes
            //Thread serpienteUno = new Thread();
            //serpienteUno.Start();
            //Thread serpienteDos = new Thread(serpiente);
            //serpienteDos.Start();
            //Thread serpienteTres = new Thread(serpiente);
            //serpienteTres.Start();
            //Thread serpienteCuatro = new Thread(serpiente);
            //serpienteCuatro.Start();

        }


    }
}

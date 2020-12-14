using System;
using System.Threading;
using System.Text;
using System.Collections.Concurrent;
using System.Linq;

namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart usuarios = new ThreadStart(Usuario.InsertVectorUser);
            Thread hiloUsuario = new Thread(usuarios);
            hiloUsuario.Start();

            //ThreadStart semillas = new ThreadStart(Usuario.InsertVectorUser);
            //Thread hiloUsuario = new Thread(usuarios);
            //hiloUsuario.Start();

        }
    }
}

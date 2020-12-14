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
            ThreadStart usuarios = new ThreadStart(Usuario.InsertVectorUser); // crea hilo para usuarios
            Thread hiloUsuario = new Thread(usuarios); // objeto de tipo hilo con parametro usuarios
            hiloUsuario.Start(); // inicia hilo de usuario

            //ThreadStart semillas = new ThreadStart(Usuario.InsertVectorUser);
            //Thread hiloUsuario = new Thread(usuarios);
            //hiloUsuario.Start();

        }
    }
}

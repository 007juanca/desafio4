using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_4
{
    internal class Programa4
    {
        static string usuario = "";
        static string contrasena = "";

        static void Main(string[] args)
        {
            Registrarse();
            IniciarSesion();
            Console.ReadKey();
        }

        static void Registrarse()
        {
            Console.WriteLine("................Registrarse..................");
            Console.WriteLine("Ingrese un nombre de Usuario...");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña de su Usuario...");
            contrasena = Console.ReadLine();
            Console.WriteLine("................Cuenta creada................");
        }

        static void IniciarSesion()
        {
            Console.WriteLine("...........Iniciar Sesión..................");
            Console.WriteLine("Ingrese su nombre de Usuario...");
            string usuarioregistrado = Console.ReadLine();
            Console.WriteLine("Ingrese la contrasenia de su Usuario...");
            string contrasenaguardada = Console.ReadLine();


            if (usuario.ToLower().Equals(usuarioregistrado.ToLower()))
            {
                if (contrasena.Equals(contrasenaguardada))
                {
                    Console.WriteLine("Bienvenido {0}", usuarioregistrado);
                }
            }
            else
            {
                Console.WriteLine("La contraseña es invalida");
            }
        }
    }
}
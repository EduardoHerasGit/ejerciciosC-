using System;

namespace PracticaMetodosYClases
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejercicio 6: Control de Login ---");
            int intentosMaximos = 3;
            int intentosRealizados = 0;
            bool loginCorrecto = false;

            while (intentosRealizados < intentosMaximos && !loginCorrecto)
            {
                intentosRealizados++;
                Console.WriteLine($"
--- Intento {intentosRealizados} de {intentosMaximos} ---");
                
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                string password = Console.ReadLine();

                loginCorrecto = ValidarLogin(usuario, password);

                if (loginCorrecto)
                {
                    Console.WriteLine("
¡Acceso concedido! Bienvenido al sistema.");
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrectos.");
                }
            }

            if (!loginCorrecto)
            {
                Console.WriteLine("
Has superado el número máximo de intentos permisibles. Acceso bloqueado.");
            }
        }

        /// <summary>
        /// Comprueba si el usuario y contraseña son correctos.
        /// </summary>
        static bool ValidarLogin(string usuario, string password)
        {
            return usuario == "usuario2DAM" && password == "pass2DAM";
        }
    }
}

using System;

namespace Eje22
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /************
            * Ejercicio 22
            * ***********/
            string password = "Tantas3?";
            int intentos = 0;
            string password2;
            while (intentos < 3)
            {

                Console.WriteLine("Introduzca contraseña: ");
                password2 = Console.ReadLine();
                if (password == password2)
                {
                    Console.WriteLine("Enhorabuena");
                    break;
                }
                else
                {
                    ++intentos;
                }
            }
        }
    }
}

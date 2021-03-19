using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            // Variables
            int altura, i,
                incremento = 0;

            // Mensajes
            Console.Title = "Ejercicio 09";
            Console.WriteLine("Dibuja una piramide de asteriscos\n" +
                              "---------------------------------");

            // Ingreso de datos
            Console.Write("Ingrese altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            // Dibujo
            while (incremento <= altura)
            {
                incremento++;
                for (i = 0; i < incremento; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
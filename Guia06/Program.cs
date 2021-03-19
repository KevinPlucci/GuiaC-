using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            // Variables
            float anio;
            Console.Title = "Ejercicio 06";
            Console.WriteLine("Comprobar si un año es biciesto\n" +
                              "--------------------------------");
            // Ingreso de datos
            Console.Write("Ingrese año: ");
            anio = float.Parse(Console.ReadLine());

            // Calculo
            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                Console.WriteLine("Es biciesto");
            }
            else
            {
                Console.WriteLine("No es biciesto");
            }
            Console.ReadLine();
        }
    }
}
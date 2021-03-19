using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            // Variables
            DateTime nacimiento;
            DateTime hoy;
            TimeSpan diferencia;
            bool prueba;


            Console.Title = "Ejercicio 07";
            Console.WriteLine("Saber dias de vida\n" +
                              "------------------");

            Console.Write("Ingrese fecha de nacimiento DD/MM/AA: ");

            do
            {
                prueba = DateTime.TryParse(Console.ReadLine(), out nacimiento);
                if (!prueba)
                {
                    Console.WriteLine("Error");
                    Console.Write("Ingrese fecha de nacimiento DD/MM/AA: ");
                }

            } while (!prueba);

            hoy = DateTime.Now;



            diferencia = hoy - nacimiento;
            Console.WriteLine("Los dias de vida vividos son: {0}", diferencia.Days);
            Console.ReadLine();
        }
    }
}
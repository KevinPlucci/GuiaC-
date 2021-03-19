using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 03 numeros primos

            string numero;
            int numeroEntero;
            Console.WriteLine("Ingrese un numero:");
            numero = Console.ReadLine();
            numeroEntero = int.Parse(numero);

            while (numeroEntero < 0)
            {
                Console.WriteLine("Error, Re ingrese un numero:");
                numero = Console.ReadLine();
                numeroEntero = int.Parse(numero);
            }


            for (int i = 0; i <= numeroEntero; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    //Console.WriteLine("{0} {1}", i, j);
                    if (j != 1 && i % j == 0)
                    {
                        // si encuentra un numero que dividio otro te da resto cero, rompe el for y prueba con el siguiente numero
                        break;
                    }

                    if (j == i - 1)
                    {
                        // si ya probo todos los numeros y nunca se rompio el for (osea que llego al numero i - 1) imprime que ese numero es primo
                        Console.WriteLine("{0} es primo.", i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
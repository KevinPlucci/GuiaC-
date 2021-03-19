using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia05
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 05
            //encontrar el centro numerico de los dos numeros que elije el usuario 
            //y avisar si no hay centro

            string numero;
            int numeroEntero;
            Console.WriteLine("Ingrese un numero:");
            numero = Console.ReadLine();
            numeroEntero = int.Parse(numero);

            int acumuladorJ = 0;
            int j = 0;
            int acumuladorX = 0;
            int x = 0;

            int flag = 0;

            while (numeroEntero < 0)
            {
                Console.WriteLine("Error, Re ingrese un numero:");
                numero = Console.ReadLine();
                numeroEntero = int.Parse(numero);
            }

            for (int i = 1; i <= numeroEntero; i++)
            {
                acumuladorJ = 0;
                acumuladorX = 0;

                for (j = numeroEntero; j > i; j--)
                {
                    acumuladorJ = acumuladorJ + j;
                }

                for (x = 1; x < i; x++)
                {
                    acumuladorX = acumuladorX + x;
                }

                if (acumuladorX == acumuladorJ)
                {
                    flag = i;
                }
            }
            if (flag != 0)
            {
                Console.WriteLine("El centro numerico es: {0}.", flag);
            }
            else
            {
                Console.WriteLine("No hay centro numerico entre 1 y {0}.", numeroEntero);
            }
            Console.ReadKey();
        }

    }
   
}

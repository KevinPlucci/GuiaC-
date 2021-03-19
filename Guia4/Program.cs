using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Ejercicio 4
                //numero perfecto es un numero entero positivo que es igual a la suma de todos los enteros positivos 
                //(excluido el mismo) que son divisores del numero

                int acumulador = 0;
                int flag = 0;
                int i = 0;

                while (flag != 4)
                {
                    i++;
                    for (int j = 1; j < i; j++)
                    {
                        //Console.WriteLine("iteracion {0} {1}", i, j);
                        if (i % j == 0)
                        {
                            acumulador = acumulador + j;
                            //Console.WriteLine("Acumulador {0} ", acumulador);
                        }
                        if (j == i - 1 && acumulador == i)
                        {
                            Console.WriteLine("{0} ES UN NUMERO PERFECTO.", i);
                            flag = flag + 1;
                            break;
                        }
                    }
                    acumulador = 0;
                }
                Console.ReadKey();
            }
        }
    }
}
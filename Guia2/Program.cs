using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("Ingrese un numero");
            numero = Console.ReadLine();
            while(int.Parse(numero)<0)
            {
                Console.WriteLine("Numero incorrecto");
                numero = Console.ReadLine();
            }
            
            Console.WriteLine(Math.Pow(int.Parse(numero),2));
            Console.WriteLine(Math.Pow(int.Parse(numero),3));
            Console.ReadKey();
        }
    }
}

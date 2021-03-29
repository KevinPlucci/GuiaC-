using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliUno = new Boligrafo(100, ConsoleColor.Blue);
            //Boligrafo boliDos = new Boligrafo(50, ConsoleColor.Red);
            string lele = string.Empty;


            //Console.WriteLine(boliUno.GetColor());
            //Console.WriteLine(boliUno.GetTinta());

            Console.WriteLine("Cantidad de tinta inicial: " + boliUno.GetTinta());
            if (boliUno.Pintar(15, out lele))//si es true 
            {
                Console.WriteLine("Color de la tinta: " + boliUno.GetColor());
                Console.Write("Dibujo:");
                Console.ForegroundColor = boliUno.GetColor();
                Console.WriteLine(lele);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cantidad de tinta ahora: " + boliUno.GetTinta());
                Console.WriteLine("------Aplico una recarga de tinta------");
                boliUno.Recargar();
                Console.WriteLine("Cantidad de tinta actual: " + boliUno.GetTinta());
            }
            Console.ReadKey();
        }
    }
}
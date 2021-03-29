using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;
namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo(new Punto(5, 0), new Punto(0, 7));
            MostrarRectangulo(r1);
            Console.WriteLine("El valor del area es :{0} \n El valor del perimeto es {1}", r1.Area(), r1.Perimetro());
            Console.ReadKey();
        }

        public static void MostrarRectangulo(Rectangulo rec)
        {
            Console.WriteLine("El vertice1 es : (" + rec.GetVertice1().GetX() + "," + rec.GetVertice1().GetY() + ") \n El vertice 2 es : (" + rec.GetVertice2().GetX() + "," + rec.GetVertice2().GetY() + ")  \n El vertice 3 es : (" + rec.GetVertice3().GetX() + "," + rec.GetVertice3().GetY() + ")  \n El vertice 4 es : (" + rec.GetVertice4().GetX() + "," + rec.GetVertice4().GetY() + ") ");
        }
    }
}

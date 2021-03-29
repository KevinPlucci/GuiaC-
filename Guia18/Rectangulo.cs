using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area = 0;
        private float perimetro = 0;
        private float baseR;
        private float alturaR;
        /*
         
        V3 _________________V4
        |                    |
        |                    |
        |                    |
        |____________________|
        V2                   V1

        El vertice 1 me da la base
        El vertice 3 me la altura
        Tomo siempre como inicio el punto 0,0 (v2)
         */

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(0, 0);
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.baseR = Math.Abs(this.vertice2.GetX() - this.vertice1.GetX());
            this.alturaR = Math.Abs(this.vertice2.GetY() - this.vertice3.GetX());

        }
        #region Getters
        public Punto GetVertice1()
        {
            return this.vertice1;
        }
        public Punto GetVertice2()
        {
            return this.vertice2;
        }
        public Punto GetVertice3()
        {
            return this.vertice3;
        }
        public Punto GetVertice4()
        {
            return this.vertice4;
        }
        #endregion Getters
        public float Area()
        {
            if (this.area == 0)
            {
                this.area = this.baseR * this.alturaR;
            }
            return this.area;
        }

        public float Perimetro()
        {
            if (this.perimetro == 0)
            {
                this.perimetro = ((this.baseR + this.alturaR) * 2);
            }
            return this.perimetro;
        }
    }
}

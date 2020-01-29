using System;
using System.Collections.Generic;
using System.Text;

namespace Cap4ex03
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro;
            perimetro = (Largura + Altura) * 2;
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);
            diagonal = Math.Sqrt(diagonal);
            return diagonal;
        }


    }
}

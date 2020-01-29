using System;
using System.Globalization;

namespace Cap4ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.Write("Digite a Largura do Retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a Altura do Retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("ÁREA: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

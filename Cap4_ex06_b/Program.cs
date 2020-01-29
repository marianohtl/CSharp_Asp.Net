using System;
using System.Globalization;

namespace Cap4_ex06_b
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                Calculadora calc = new Calculadora();
                Console.WriteLine("Entre com o valor do raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double circ = calc.Circunferencia(raio);
                double volume = calc.Volume(raio);

                Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}


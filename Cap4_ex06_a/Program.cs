using System;
using System.Globalization;

namespace Cap4_ex06_a
{
    class Program
    {
        //vamos declarar a constante PI e ela será estática, pois será usada em outra classe estática
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        //Aqui não necessitamos do encapsulador public, pois estamos trabalhando dentro da mesma classe,
        //porém para que essa função funcione dentro de MAIN precisamos usar o static, pois o Main é uma função statica, 
        //e não podemos chamar uma função estática da mesma classe dentro de uma função estática  

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}

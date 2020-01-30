using System;
using System.Globalization;

namespace Cap4_ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoedas.Cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoedas.Dolares = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor a ser pago em reais = "+ConversorDeMoedas.Converter().ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}

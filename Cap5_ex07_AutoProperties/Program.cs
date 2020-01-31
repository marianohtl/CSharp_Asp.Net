using System;
using System.Globalization;

namespace Cap5_ex07_AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Apple",50.55,9);
            p.Nome = "A";
            Console.WriteLine(p);
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            
        }
    }
}

using System;

namespace Cap5_ex06_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Banana",500.00,10);
            Console.WriteLine(p);
            p.Nome = "Bananas";
            p.Nome = "B"; //a propertie barrou o B
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}

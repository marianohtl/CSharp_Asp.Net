using System;
using System.Globalization;

namespace Cap5_ex05_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("Banana", 500.00,10);
            Console.WriteLine(p.GetNome());
            p.SetNome("B");
            Console.WriteLine(p.GetNome());
            p.SetNome("Bananas");
            Console.WriteLine(p.GetNome());
            //Aqui, conforme os métodos que construímos, podemos mostrar o preço e a quantidade, porém não conseguimos alterá-los
            // _quantidade = 10;   erro
            //SetPreco(100.00)
            p.GetPreco();
            p.GetQuantidade();



            /*Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            /*
            Produto p = new Produto
            {
                Nome = "tv",
                Preco = 900.00,
                Quantidade = 10
            };
            

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */
        }
    }
}

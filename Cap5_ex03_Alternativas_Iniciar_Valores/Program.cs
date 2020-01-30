using System;
using System.Globalization;

namespace Cap5_ex03_Alternativas_Iniciar_Valores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Construtor padrão funciona, pois não há construtores declarados
            //Para usar estes dois construtores e declarar um construtor com sobrecarga, precisamos declarar o construtor padrão na classe pai
            Produto pPadrao = new Produto(); 
            //Outra forma de instanciar e atribuir valores a um objeto sem usar o construtor
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
        }
    }
}

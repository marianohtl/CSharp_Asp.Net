using System;

namespace Cap04Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod1 = new Produto();
            int quantidade;
            
            Console.WriteLine("ENTRE COM OS DADOS DO PRODUTO:");
            Console.Write("Nome: ");
            prod1.Nome = Console.ReadLine();
            Console.Write("Peço: ");
            prod1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            prod1.Quantidade = int.Parse(Console.ReadLine());

            //Aqui conseguimos deixar somente a variável p pois usamos o ToString do Object
            //COM ISSO SEMPRE QUE COLOCARMOS O MÉTODO WRITE LINE DENTRO DO OBJETO ELE IMPLICITAMENTE VAI CHAMAR O MÉTODO TO STRING E TRARÁ A CONVERSÃO DEFINIDA DENTRO DO MÉTODO
            Console.WriteLine("DADOS DO PRODUTO: " + prod1); //SOMENTE OBJETO > RETORNO TO STRINGf
            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            prod1.AdicionarProdutos(quantidade);
            Console.WriteLine("DADOS ATUALIZADOS DO PRODUTO: " + prod1);
            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            prod1.RemoverProdutos(quantidade);
            Console.WriteLine("DADOS ATUALIZADOS DO PRODUTO: " + prod1);


        }
    }
}

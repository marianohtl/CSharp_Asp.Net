using System;

namespace O.O.CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cap3Ex03 ex = new Cap3Ex03();
            bool continuar = true;
            while (continuar == true)
            {
                string opcao;
                Console.WriteLine("######################################################################");
                Console.WriteLine("Lista de Exercícios 02 - Capítulo 3 - Estrutura Condicional(if-else)");
                Console.WriteLine("######################################################################");
                Console.WriteLine("Escolha o exercício:");
                Console.WriteLine("#1 - Coordenadas com While");
                Console.WriteLine("#2 - Posto de Gasolina");
                Console.WriteLine("#0 - Sair");
                Console.WriteLine("######################################################################");
                Console.Write("#");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #1 - Coordenadas com While");
                        Console.WriteLine("---------------------------------------");
                        ex.CoordenadasWhile();
                        break;

                    case "2":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #2 - Posto de Gasolina");
                        Console.WriteLine("---------------------------------------");
                        ex.PostoGasolina();
                        break;
                    case "0":
                        Console.WriteLine("Goodbye :)");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }



        }
    }
}

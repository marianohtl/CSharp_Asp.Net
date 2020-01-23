using System;

namespace O.O.CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cap3Ex02 ex = new Cap3Ex02();
            bool continuar = true;
            while (continuar == true)
            {
                string opcao;
                Console.WriteLine("######################################################################");
                Console.WriteLine("Lista de Exercícios 02 - Capítulo 3 - Estrutura Condicional(if-else)");
                Console.WriteLine("######################################################################");
                Console.WriteLine("Escolha o exercício:");
                Console.WriteLine("#1 - Números Negativos");
                Console.WriteLine("#2 - Pares ");
                Console.WriteLine("#3 - Múltiplos");
                Console.WriteLine("#4 - Hora do Jogo");
                Console.WriteLine("#5 - Intervalos");
                Console.WriteLine("#6 - Eixos");
                Console.WriteLine("#7 - Impostos");
                Console.WriteLine("#0 - Sair");
                Console.WriteLine("######################################################################");
                Console.Write("#");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #1 - Números Negativos");
                        Console.WriteLine("---------------------------------------");
                        ex.Negativos();
                        break;

                    case "2":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #2 - Pares");
                        Console.WriteLine("---------------------------------------");
                        ex.Pares();
                        break;
                    case "3":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #3 - Múltiplos");
                        Console.WriteLine("---------------------------------------");
                        ex.Multiplos();
                        break;
                    case "4":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #4 - Hora do Jogo");
                        Console.WriteLine("---------------------------------------");
                        ex.HoraJogo();
                        break;

                    case "5":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #5 - Intervalos");
                        Console.WriteLine("---------------------------------------");
                        ex.Intervalos();
                        break;
                    case "6":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #6 - Eixos");
                        Console.WriteLine("---------------------------------------");
                        ex.Eixos();
                        break;
                    case "7":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #7 - Impostos");
                        Console.WriteLine("---------------------------------------");
                        ex.Impostos();
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

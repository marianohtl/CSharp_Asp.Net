using System;

namespace O.O.CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cap3Ex04 ex = new Cap3Ex04();
            bool continuar = true;
            while (continuar == true)
            {
                string opcao;
                Console.WriteLine("######################################################################");
                Console.WriteLine("Lista de Exercícios 04 - Capítulo 3 - Estrutura Condicional (for)");
                Console.WriteLine("######################################################################");
                Console.WriteLine("Escolha o exercício:");
                Console.WriteLine("#1 -  Ímpar ");
                Console.WriteLine("#2 -  Média Ponderada");
                Console.WriteLine("#3 -  Divisão com For");
                Console.WriteLine("#4 -  Fatorial");
                Console.WriteLine("#5 -  Divisores de N");
                Console.WriteLine("#6 -  Número | Quadrado Deste Número | Cubo Deste Número");
                Console.WriteLine("#0 -  Sair");
                Console.WriteLine("######################################################################");
                Console.Write("#");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #1 -  Ímpar ");
                        Console.WriteLine("---------------------------------------");
                        ex.Impar();
                        break;

                    case "2":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #2 -  Média Ponderada de N Valores");
                        Console.WriteLine("---------------------------------------");
                        ex.MediaPonderada();
                        break;
                    case "3":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #3 - Divisões com For");
                        Console.WriteLine("---------------------------------------");
                        ex.Divisao();
                        break;
                    case "4":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #4 - Fatorial");
                        Console.WriteLine("---------------------------------------");
                        ex.Fatorial();
                        break;   
                    case "5":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #5 -  Divisores de N ");
                        Console.WriteLine("---------------------------------------");
                        ex.DivisoresNum();
                        break; 
                    case "6":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #6 -  Número | Quadrado Deste Número | Cubo Deste Número ");
                        Console.WriteLine("---------------------------------------");
                        ex.NumQuadCub();
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

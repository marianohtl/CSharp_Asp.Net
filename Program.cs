using System;

namespace O.O.CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cap3Ex01 ex = new Cap3Ex01();
            bool continuar = true;
            while (continuar == true)
            {
                string opcao;
                Console.WriteLine("############################################################");
                Console.WriteLine("          Lista de Exercícios 01 - Capítulo 3");
                Console.WriteLine("############################################################");
                Console.WriteLine("Escolha o exercício:");
                Console.WriteLine("#1 - Soma");
                Console.WriteLine("#2 - Diferença");
                Console.WriteLine("#3 - Calculando Salário");
                Console.WriteLine("#4 - Calculando Áreas Distintas");
                Console.WriteLine("#0 - Sair");
                Console.WriteLine("############################################################");
                Console.Write("#");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #1 - Soma");
                        Console.WriteLine("---------------------------------------");
                        ex.Soma();
                        break;

                    case "2":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #2 - Diferença");
                        Console.WriteLine("---------------------------------------");
                        ex.Diferenca();
                        break;
                    case "3":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #3 - Calculando Salário");
                        Console.WriteLine("---------------------------------------");
                        ex.Salario();
                        break;
                    case "4":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #4 - Calculando Área Distintas");
                        Console.WriteLine("---------------------------------------");
                        ex.CalcAreas();
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

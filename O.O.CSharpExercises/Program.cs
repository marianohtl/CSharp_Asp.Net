using System;

namespace O.O.CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBasicOO ex = new TestBasicOO();
            bool continuar = true;
            while (continuar == true)
            {
                string opcao;
                Console.WriteLine("############################################################");
                Console.WriteLine("Algorítimo Resultante de um Teste de Lógica de Programação");
                Console.WriteLine("############################################################");
                Console.WriteLine("Escolha o exercício:");
                Console.WriteLine("#1");
                Console.WriteLine("#2");
                Console.WriteLine("#3");
                Console.WriteLine("#4");
                Console.WriteLine("#5");
                Console.WriteLine("#6");
                Console.WriteLine("#0");
                Console.WriteLine("############################################################");
                Console.Write("#");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #1 - Calculando dois Preços");
                        Console.WriteLine("---------------------------------------");
                        ex.CalcPreco();
                        break;

                    case "2":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #2 - A Área de um Círculo");
                        Console.WriteLine("---------------------------------------");
                        ex.CircleArea();
                        break;
                    case "3":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #3 - Tabela de Lanches e Bebidas");
                        Console.WriteLine("---------------------------------------");
                        ex.Lanches();
                        break;
                    case "4":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #4 - Verificar Senha");
                        Console.WriteLine("---------------------------------------");

                        ex.EquSegundoGrau();
                        break;
                    case "5":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #5 - Verificar Senha");
                        Console.WriteLine("---------------------------------------");
                        ex.VerificaSenha();
                        break;
                    case "6":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #6 - Intervalo de 10 à 20");
                        Console.WriteLine("---------------------------------------");
                        ex.Intervalos();
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

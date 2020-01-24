using System;

namespace O.O.CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBasicOO ex00 = new TestBasicOO();
            Cap3Ex01 ex01 = new Cap3Ex01();
            Cap3Ex02 ex02 = new Cap3Ex02();
            Cap3Ex03 ex03 = new Cap3Ex03();
            Cap3Ex04 ex04 = new Cap3Ex04();

            bool continuar = true;
            
            while (continuar == true)
            {
                string opcao;
                Console.WriteLine("######################################################################");
                Console.WriteLine("Lista de Exercícios 04 - Capítulo 3 - Estrutura Condicional (for)");
                Console.WriteLine("######################################################################");
                Console.WriteLine("Escolha o Exercício:");
                Console.WriteLine("######################################################################");
                Console.WriteLine("##1  -  Calculando dois Preços  ");
                Console.WriteLine("##2  -  A Área de um Círculo");
                Console.WriteLine("##3  -  Tabela de Lanches e Bebidas");
                Console.WriteLine("##4  -  Equação 2º Grau");
                Console.WriteLine("##5  -  Verificar Senha");
                Console.WriteLine("##6  -  Intervalo de 10 à 20");
                Console.WriteLine("##7  -  Soma");
                Console.WriteLine("##8  -  Diferença");
                Console.WriteLine("##9  -  Calculando Salário");
                Console.WriteLine("#10  -  Calculando Área Distintas");
                Console.WriteLine("#11  -  Números Negativos");
                Console.WriteLine("#12  -  Pares");
                Console.WriteLine("#13  -  Múltiplos");
                Console.WriteLine("#14  -  Hora do Jogo");
                Console.WriteLine("#15  -  Intervalos");
                Console.WriteLine("#16  -  Eixos");
                Console.WriteLine("#17  -  Impostos");
                Console.WriteLine("#18  -  Coordenadas com While");
                Console.WriteLine("#19  -  Posto de Gasolina");
                Console.WriteLine("#20  -  Ímpar");
                Console.WriteLine("#21  -  Média Ponderada");
                Console.WriteLine("#22  -  Divisão com For");
                Console.WriteLine("#23  -  Fatorial");
                Console.WriteLine("#24  -  Divisores de N");
                Console.WriteLine("#25  -  Número | Quadrado Deste Número | Cubo Deste Número");
                Console.WriteLine("##0  -  Sair");
                Console.WriteLine("######################################################################");
                Console.Write("#");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #1 - Calculando dois Preços");
                        Console.WriteLine("---------------------------------------");
                        ex00.CalcPreco();
                        break;

                    case "2":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #2 - A Área de um Círculo");
                        Console.WriteLine("---------------------------------------");
                        ex00.CircleArea();
                        break;
                    case "3":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #3 - Tabela de Lanches e Bebidas");
                        Console.WriteLine("---------------------------------------");
                        ex00.Lanches();
                        break;
                    case "4":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #4 - Equação 2º Grau");
                        Console.WriteLine("---------------------------------------");
                        ex00.EquSegundoGrau();
                        break;
                    case "5":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #5 - Verificar Senha");
                        Console.WriteLine("---------------------------------------");
                        ex00.VerificaSenha();
                        break;
                    case "6":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #6 - Intervalo de 10 à 20");
                        Console.WriteLine("---------------------------------------");
                        ex00.Intervalos();
                        break;
                    case "7":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #7 - Soma");
                        Console.WriteLine("---------------------------------------");
                        ex01.Soma();
                        break;

                    case "8":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #8 - Diferença");
                        Console.WriteLine("---------------------------------------");
                        ex01.Diferenca();
                        break;
                    case "9":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #9 - Calculando Salário");
                        Console.WriteLine("---------------------------------------");
                        ex01.Salario();
                        break;
                    case "10":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #10 - Calculando Área Distintas");
                        Console.WriteLine("---------------------------------------");
                        ex01.CalcAreas();
                        break;
                    case "11":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #11 - Números Negativos");
                        Console.WriteLine("---------------------------------------");
                        ex02.Negativos();
                        break;
                    case "12":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #12 - Pares");
                        Console.WriteLine("---------------------------------------");
                        ex02.Pares();
                        break;
                    case "13":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #13 - Múltiplos");
                        Console.WriteLine("---------------------------------------");
                        ex02.Multiplos();
                        break;
                    case "14":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #14 - Hora do Jogo");
                        Console.WriteLine("---------------------------------------");
                        ex02.HoraJogo();
                        break;
                    case "15":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #15 - Intervalos");
                        Console.WriteLine("---------------------------------------");
                        ex02.Intervalos();
                        break;
                    case "16":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #16 - Eixos");
                        Console.WriteLine("---------------------------------------");
                        ex02.Eixos();
                        break;
                    case "17":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #17 - Impostos");
                        Console.WriteLine("---------------------------------------");
                        ex02.Impostos();
                        break;
                    case "18":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #18 - Coordenadas com While");
                        Console.WriteLine("---------------------------------------");
                        ex03.CoordenadasWhile();
                        break;

                    case "19":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #19 - Posto de Gasolina");
                        Console.WriteLine("---------------------------------------");
                        ex03.PostoGasolina();
                        break;
                    case "20":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #20 -  Ímpar ");
                        Console.WriteLine("---------------------------------------");
                        ex04.Impar();
                        break;
                    case "21":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #21 -  Média Ponderada de N Valores");
                        Console.WriteLine("---------------------------------------");
                        ex04.MediaPonderada();
                        break;
                    case "22":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #22 - Divisões com For");
                        Console.WriteLine("---------------------------------------");
                        ex04.Divisao();
                        break;
                    case "23":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #23 - Fatorial");
                        Console.WriteLine("---------------------------------------");
                        ex04.Fatorial();
                        break;   
                    case "24":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #24 -  Divisores de N ");
                        Console.WriteLine("---------------------------------------");
                        ex04.DivisoresNum();
                        break; 
                    case "25":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exercício #25 -  Número | Quadrado Deste Número | Cubo Deste Número ");
                        Console.WriteLine("---------------------------------------");
                        ex04.NumQuadCub();
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

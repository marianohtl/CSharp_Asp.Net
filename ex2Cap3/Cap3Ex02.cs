using System;
using System.Collections.Generic;
using System.Text;

namespace O.O.CSharpExercises
{
    class Cap3Ex02
    {
        public void Negativos()
        {
            double num;
            Console.WriteLine("Digite um número: ");
            num = double.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Este número é negativo!");
            }
            else if (num == 0)
            {
                Console.WriteLine("Este número é neutro (nulo)!");
            }
            else
            {
                Console.WriteLine("Este número não é negativo!");
            }
        }

        public void Pares()
        {
            double num;
            Console.WriteLine("Digite um número: ");
            num = double.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }
        }

        public void Multiplos()
        {
            int num;
            int num2;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num % num2 == 0 || num2 % num == 0)
            {
                Console.WriteLine("São múltiplos!");
            }
            else
            {
                Console.WriteLine("Não são múltiplos!");
            }
        }


        public void HoraJogo()
        {
            int inicio;
            int fim;
            int totalPartida = 0;
            Console.WriteLine("Digite a hora de início do jogo:");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora do fim do jogo:");
            fim = int.Parse(Console.ReadLine());
            if (inicio <= 23 && fim > inicio)
            {
                totalPartida = fim - inicio;
            }
            else if (fim == 0 || fim == 00)
            {
                totalPartida = 24 - inicio;
            }
            else if (fim <= inicio)
            {
                totalPartida = (24 - inicio) + fim;
            }
            else
            {
                Console.WriteLine("Valor Inválido");
            }


            Console.WriteLine($"O jogo durou {totalPartida}:00 hora(s).");
        }

        public void Intervalos()
        {
            double intervalo;
            Console.WriteLine("Digite um valor:");
            intervalo = double.Parse(Console.ReadLine());
            if (intervalo >= 0.0 && intervalo <= 25.00)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (intervalo > 25.00 && intervalo <= 50.00)
            {
                Console.WriteLine("Intervalo [25, 50]");

            }
            else if (intervalo > 50.00 && intervalo <= 75.00)
            {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else if (intervalo > 75.00 && intervalo <= 100.00)
            {
                Console.WriteLine("Intervalo [75, 100]");
            }
            else
            {
                Console.WriteLine("Fora do Intervalo!");
            }
        }

        public void Eixos()
        {
            double x;
            double y;
            Console.WriteLine("Diga as coordenas para o eixo X:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga as coordenas para o eixo Y:");
            y = double.Parse(Console.ReadLine());

            if (x == 0.00 && y == 0.00)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (y < 0.0 && x > 0.0)
            {
                Console.WriteLine("Q4");
            }

        }


        public void Impostos()
        {
            double isento = 2000.00;
            double roubo1 = 0, roubo2 = 0, roubo3 = 0, excesso=0, valor,rouboTotal;
            Console.WriteLine("Diga o seu salário:");
            valor = double.Parse(Console.ReadLine());

            excesso = valor - isento;

            if(excesso <= 1000.00)
            {
                roubo1 = excesso * 0.08;
                
            } else if (excesso > 1000.00 && excesso <= 2500.00)
            {
                roubo1 = 1000.00 * 0.08;
                roubo2 = excesso - 1000.00;
                roubo2 = roubo2 * 0.18;
            }else if (excesso > 2500.00)
            {
                roubo1 = 1000.00 * 0.08;
                roubo2 = 1500.00 * 0.18;
                roubo3 = excesso - 2500.00;
                roubo3 = roubo3 * 0.28;
            }

            rouboTotal = roubo1 + roubo2 + roubo3;
            Console.WriteLine("##############################################");
            Console.WriteLine("Roubado1: R$"+roubo1.ToString("F2"));
            Console.WriteLine("Roubado2: R$"+roubo2.ToString("F2"));
            Console.WriteLine("Roubado3: R$"+roubo3.ToString("F2"));
            Console.WriteLine("Total Roubado: R$"+rouboTotal.ToString("F2"));
            Console.WriteLine("##############################################");

        }

    }
}

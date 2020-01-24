using System;
using System.Collections.Generic;
using System.Text;

namespace O.O.CSharpExercises
{
    class Cap3Ex04
    {
        public void Impar()
        {
            int num;
            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }

        }

        public void MediaPonderada()
        {
            int n;
            Console.WriteLine("Digite um valor: ");
            n = int.Parse(Console.ReadLine());
            for(int i =1; i <= n; i++)
            {
                double media, a, b, c;
                Console.WriteLine("Digite o valor A: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor B: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor C: ");
                c = double.Parse(Console.ReadLine());

                media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;
                Console.WriteLine(media.ToString("F2"));
            }
        }


        public void Divisao()
        {
            int N;
            Console.WriteLine("Quantos pares de números tu quer dividir? ");
            N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                double[] valor1 = new double[N];
                double[] valor2 = new double[N];
                double div;
                Console.WriteLine("Digite o primeiro valor:");
                valor1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                valor2[i] = double.Parse(Console.ReadLine());
                if(valor2[i] == 0)
                {
                    Console.WriteLine("Divisão impossível!");
                }
                else{
                    div = valor1[i] / valor2[i];
                    Console.WriteLine(div);
                }
            }

        }

        public void Fatorial() {
            int F, fatorial = 1;
            Console.WriteLine("Você quer saber o fatorial de qual número?");
            F = int.Parse(Console.ReadLine());
            if (F == 0)
            {
                fatorial = 1;
            }
            else
            {
                for (int i = 1; i <= F; i++)
                {
                   fatorial *= i;  
                }
            }
            Console.WriteLine(fatorial);

        }

        public void DivisoresNum()
        {
            double num;
            Console.WriteLine("Digite um numero:");
            num = double.Parse(Console.ReadLine());
            for(int i =1; i <= num; i++)
            {
                if(num % i == 0) { 
                Console.WriteLine(i);
                }
            }
        
        }

        public void NumQuadCub()
        {
            double num1;
            Console.WriteLine("Digite o número de linhas:");
            num1 = double.Parse(Console.ReadLine());
            for (int i =1; i <= num1 ;i++)
            {
                Console.WriteLine(i +" "+ Math.Pow(i,2) + " " + Math.Pow(i, 3));
            }
        }



    }
  }
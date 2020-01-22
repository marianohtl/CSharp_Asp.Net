using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace O.O.CSharpExercises
{
    class TestBasicOO
    {



        public void CalcPreco()
        {
            int codigo;
            int quantidade;
            int quantidade2;
            double precoUnit;
            double precoUnit2;
            double precoTotal;

            Console.WriteLine("Digite o código do 1º produto:");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos:");
            quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço deste produto:");
            precoUnit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite o código do 2º produto:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de produtos:");
            quantidade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço deste produto:");
            precoUnit2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            precoTotal = (precoUnit * quantidade) + (precoUnit2 * quantidade2);

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Valor total a pagar pelos produtos: R$" + precoTotal.ToString("F2"));
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public void CircleArea()
        {
            double raio;
            double area;
            const double PI = 3.14159;
            Console.WriteLine("Digite o raio do seu círculo:");
            raio = double.Parse(Console.ReadLine());
            area = PI * Math.Pow(raio, 2);
            Console.WriteLine("A área do seu círculo é " + area.ToString("F4"));

        }

        public void Lanches()
        {
            string codigo;
            int qntd;
            double pagTotal;
            Console.WriteLine("############################################################");
            Console.WriteLine("                    Faça o seu Pedido");
            Console.WriteLine("############################################################");
            Console.WriteLine("CÓDIGO     |      ESPECIFICAÇÃO      |      PREÇO");
            Console.WriteLine("#1         |     Cachorro Quente     |      R$4,00");
            Console.WriteLine("#2         |         X-Salada        |      R$4,50");
            Console.WriteLine("#3         |         X-Bacon         |      R$5,00");
            Console.WriteLine("#4         |     Torrada Simples     |      R$2,00");
            Console.WriteLine("#5         |       Refrigerante      |      R$1,50");
            Console.WriteLine("############################################################");
            Console.WriteLine("Digite o código do seu pedido: ");
            Console.Write("#");
            codigo = Console.ReadLine();
            Console.WriteLine("Digite a quantidade que tu deseja: ");
            qntd = int.Parse(Console.ReadLine());

            if (codigo == "1")
            {
                pagTotal = qntd * 4.00;
                Console.WriteLine("Total a Pagar: R$" + pagTotal.ToString("F2"));
            }
            else if (codigo == "2")
            {
                pagTotal = qntd * 4.50;
                Console.WriteLine("Total a Pagar: R$" + pagTotal.ToString("F2"));
            }
            else if (codigo == "3")
            {
                pagTotal = qntd * 5.00;
                Console.WriteLine("Total a Pagar: R$" + pagTotal.ToString("F2"));
            }
            else if (codigo == "4")
            {
                pagTotal = qntd * 2.00;
                Console.WriteLine("Total a Pagar: R$" + pagTotal.ToString("F2"));
            }
            else if (codigo == "5")
            {
                pagTotal = qntd * 1.50;
                Console.WriteLine("Total a Pagar: R$" + pagTotal.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Este Código não Existe :/");
            }

            pagTotal = qntd * 1;
        }

        public void EquSegundoGrau()
        {
            double a;
            double b;
            double c;
            double delta;
            double x;
            double x2;
            Console.WriteLine("Digite o primeiro coeficiente:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo coeficiente:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro coeficiente:");
            c = double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            if (a != 0 && delta >= 0)
            {
                delta = Math.Sqrt(delta);
                x = (-b + delta) / (2 * a);
                x2 = (-b - delta) / (2 * a);
                Console.WriteLine("X1 = " + x.ToString("F5"));
                Console.WriteLine("X2 = " + x2.ToString("F5"));
                //            Console.WriteLine("X2 = "+ Math.Pow(x,2));

            }
            else
            {
                Console.WriteLine("Impossível Calcular!");
            }

        }

        public void VerificaSenha()
        {
            string senha = "0";
            while (senha != "2002")
            {
                Console.Write("Digite sua senha:  ");
                senha = Console.ReadLine();

                if (senha == "2002")
                {
                    Console.WriteLine("Acesso Permitido.");
                }
                else
                {
                    Console.WriteLine("Senha Inválida!");
                }
            }
        }

        public void Intervalos(){
            
            int N;
            int dentro = 0;
            int fora = 0;
            Console.WriteLine("Quantos números deseja verificar?");
            N = int.Parse(Console.ReadLine());
            
            for(int i=1; i <= N; i++)
            {
                double valor;
                
                Console.WriteLine($"Digite o {i}º valor:");
                valor = double.Parse(Console.ReadLine());

                if (valor > 10.0 && valor < 20.0)
                {
                    dentro++;
                }
                else {
                    fora++;
                }
            }
            Console.WriteLine($" {dentro} in \n {fora} out");
        
        }
    }
}


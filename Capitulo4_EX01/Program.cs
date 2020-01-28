using System;

namespace Capitulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            ex00 ex00 = new ex00();
           //Exercicio sem O.O.
           //x00.AreaTriangulo();

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A)* (p - x.B)* (p - x.C));
 
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A)* (p - y.B)* (p - y.C));

            Console.WriteLine($"A área de X = {areaX.ToString("F4")}");
            Console.WriteLine($"A área de Y = {areaY.ToString("F4")}");

            if (areaX > areaY)
            {
                Console.WriteLine("A maior área: X");
            }
            else
            {
                Console.WriteLine("A maior área: Y");
            }

            //--------------------------------------------------------

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("############################");
            Console.WriteLine("    Quem é mais velho!");
            Console.WriteLine("############################");
            Console.WriteLine("       Primeira Pessoa");
            Console.WriteLine("############################");
            Console.WriteLine("Qual é o seu nome?");
            Console.WriteLine("############################");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Qual é a sua idade?");
            pessoa1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("############################");
            Console.WriteLine("       Segunda Pessoa");
            Console.WriteLine("############################");
            Console.WriteLine("Qual é o seu nome?");
            Console.WriteLine("############################");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Qual é a sua idade?");
            pessoa2.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("############################");
            if(pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"{pessoa1.Nome} é mais velha que {pessoa2.Nome}");
            }
            else if (pessoa2.Idade > pessoa1.Idade)
            {
                Console.WriteLine($"{pessoa2.Nome} é mais velha que {pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"A idade de {pessoa1.Nome} é igual a idade de {pessoa2.Nome}.");
            }
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();
            Console.WriteLine("############################################");
            Console.WriteLine("       Primeiro Funcionário");
            Console.WriteLine("############################################");
            Console.WriteLine("Digite o nome do funcionário:");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine("############################################");
            Console.WriteLine("Digite o salário do funcionário:");
            funcionario1.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("############################################");
            Console.WriteLine("       Segundo Funcionário");
            Console.WriteLine("############################################");
            Console.WriteLine("Digite o nome do funcionário:");
            funcionario2.Nome = Console.ReadLine();
            Console.WriteLine("############################################");
            Console.WriteLine("Digite o salário do funcionário:");
            funcionario2.Salario = double.Parse(Console.ReadLine());
            double media;
            media = (funcionario1.Salario + funcionario2.Salario)/ 2;
            Console.WriteLine($"A média de salários dos funcionários é {media.ToString("F2")}.");


        }
    }
}

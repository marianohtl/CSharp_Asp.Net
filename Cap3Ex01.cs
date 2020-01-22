using System;
using System.Collections.Generic;
using System.Text;

namespace O.O.CSharpExercises
{
    class Cap3Ex01
    {
        public void Soma()
        {
            double n1;
            double n2;
            Console.WriteLine("Digite o primeiro valor:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Soma: {n1 + n2}");

        }

        public void Diferenca()
        {
            double n1;
            double n2;
            double n3;
            double n4;
            double diferenca;
            Console.WriteLine("Digite o primeiro valor:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor:");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor:");
            n4 = double.Parse(Console.ReadLine());

            diferenca = n1 * n2 - n3 * n4;
            Console.WriteLine($"A diferença entre os produtos dos números digitados é: {diferenca}");
        }

        public void Salario()
        {
            int numero;
            double valorHora;
            double horasTrabalhadas;
            double salario;

            Console.WriteLine("Informe o Nº do funcionário:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe quanto ele recebe por hora:");
            valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas ele trabalha por mês:");
            horasTrabalhadas = double.Parse(Console.ReadLine());
            salario = valorHora * horasTrabalhadas;
            Console.WriteLine($"Nº: {numero}\nSalário: R${salario.ToString("F2")}");

        }


        public void CalcAreas()
        {
            double a;
            double b;
            double c;
            double areaTriangulo;
            double areaCirculo;
            double areaTrapezio;
            double areaQuadrado;
            double areaRetangulo;
            const double PI = 3.14159;

            Console.WriteLine("1º Valor:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("2º Valor:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("3º Valor:");
            c = double.Parse(Console.ReadLine());
            areaTriangulo = a * c / 2;
            areaCirculo = PI * Math.Pow(c, 2);
            areaTrapezio = (a + b )* c / 2;
            areaQuadrado = Math.Pow(b, 2);
            areaRetangulo = a * b;
            Console.WriteLine($"A área do triângulo retângulo é: {areaTriangulo.ToString("F3")}\nA área do círculo é: {areaCirculo.ToString("F3")}\nA área do trapézio é: {areaTrapezio.ToString("F3")}\nA área do quadrado é: {areaQuadrado.ToString("F3")}\nA área do retângulo é: {areaRetangulo.ToString("F3")}");
        }

    }
}

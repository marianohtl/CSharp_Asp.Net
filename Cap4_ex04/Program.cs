using System;

namespace Cap4_ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            int aumento;

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto : ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto : ");
            f.Imposto = double.Parse(Console.ReadLine());
            f.SalarioLiquido();
            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            aumento = int.Parse(Console.ReadLine());
            f.AumentarSalario(aumento);
            Console.WriteLine("Dados Atualizados: " + f);

        }
    }
}

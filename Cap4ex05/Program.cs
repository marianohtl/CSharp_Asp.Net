using System;

namespace Cap4ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();

            Console.Write("Nome do Aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do Aluno:");
            al.Nota1 = double.Parse(Console.ReadLine());
            al.Nota2 = double.Parse(Console.ReadLine());
            al.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine(al.Avaliar());
        
        }
    }
}

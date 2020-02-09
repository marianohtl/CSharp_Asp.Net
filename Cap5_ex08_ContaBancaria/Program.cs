using System;
using System.Globalization;

// Deposito inicial opcional
// Nº da conta não pode ser alterado, porém nome titular pode
// saldo aumenta depositos e diminui por saques ( cada saque custa R$5,00)
// Precisamos: 
// realizar um depósito
//mostrar dados da conta
//realizar um saque 
//mostrar dados da conta


namespace Cap5_ex08_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Conta conta01;
            conta01 = new Conta();

            string alterar;
            
            Console.Write("Digite o número da conta: ");
            conta01.NumConta = Console.ReadLine();
            Console.Write("Digite o nome do titular da conta: ");
            conta01.Titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (S/N) ");
            alterar = Console.ReadLine();
            if(alterar == "S" || alterar == "s") { 
            Console.Write("Digite o valor que será depositado: ");
            conta01.Depositar(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\nDados da Conta: \n"  + conta01);
            Console.WriteLine(" ");
            Console.Write("Entre com um valor para depósito: ");
            conta01.Depositar(double.Parse(Console.ReadLine()));
            Console.Write("Dados da Conta: \n" + conta01);
            Console.WriteLine(" ");
            Console.Write("\nEntre com um valor para saque: ");
            conta01.FazerSaque(double.Parse(Console.ReadLine()));
            Console.Write("Dados da Conta: \n" + conta01);
            
    
            //Utilizando Correção
            Console.WriteLine();

            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (S/N) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'S' || resp == 's')  //char usa aspas simples
            {
                Console.Write("Digite o deposito inicial que será depositado: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular,depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da Conta: \n" + conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.Write("Dados da Conta: \n" + conta);
            Console.WriteLine(" ");
            Console.Write("\nEntre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.Write("Dados da Conta: \n" + conta);
            Console.WriteLine();


        }
    }
}

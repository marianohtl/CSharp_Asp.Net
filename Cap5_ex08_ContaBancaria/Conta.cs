using System;
using System.Collections.Generic;
using System.Text;

namespace Cap5_ex08_ContaBancaria
{
    class Conta
    {


        //deposito inicial opcional
        // Nº da conta não pode ser alterado porém nome titular pode
        // saldo aumenta depositos e diminui por saques ( cada saque custa R$5,00)
        // Precisamos: 
        // realizar um depósito
        //mostrar dados da conta
        //realizar um saque 
        //mostrar dados da conta

 
      
        public string Titular { get; set;}
        public string NumConta { get;  set;}

        private double _valorConta;

        public Conta()
        {
            _valorConta = 0;
        }

        public void Depositar(double valorDeposito)
        {
            _valorConta = _valorConta + valorDeposito;
        }

        public void FazerSaque(double valorSaque)
        {
            _valorConta = _valorConta - valorSaque - 5.00;
        }
        public override string ToString()
        {
            return "Nº da conta: "+ NumConta +", Nome do Titular: "+ Titular + ", Saldo: R$"+ _valorConta.ToString("F2");
        }



    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap5_ex08_ContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            //colocamos desta forma pois a lógica de depósito está encapsulada no método
            Deposito(depositoInicial);
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.00;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public override string ToString()
        {
            return "Conta: "+Numero+", Titular: "+Titular+", Saldo: R$"+Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
    }

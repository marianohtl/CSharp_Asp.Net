using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap5_ex06_Properties
{
    class Produto
    {
        //nome privativo e encapsulado, aonde dentro estará armazenado o valor do nome
        private string _nome;
        private double _preco;
        private int _quantidade;


        //AQUI TEMOS A IMPLEMENTAÇÃO DE UMA PROPERTIE DEFININDO AS OPERAÇÕES DE GET E SET
        //Aqui nos vamos expor para o  mundo externo o nome com N maiúculo na forma de propriedade
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }//usar a palavra value, seria como utilizar o parâmetro que chegaria dentro de um método set comum

        public double Preco
        {
            get
            {
                return _preco;
            }
        }

        public int Quantidade { get { return _quantidade; } }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public override string ToString()
        {
            return _nome + ", R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: R$" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap5_ex07_AutoProperties
{
    class Produto
    {   
        //Implementação de AutoPropertie
        //podemos usar m snipet para isso (atalho)  >  prop + tab + tab
        //Aqui temos o get, que pode ser usado nas demais classes, porém temos o set como método privado, aonde só pode ser alterado nesta mesma classe
        private string _nome { get; set; }//no caso do nome, como tem uma lógica particular, ele não recebe uma auto propertie
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

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

        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome+", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

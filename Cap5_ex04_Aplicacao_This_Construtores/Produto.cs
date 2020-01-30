using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap5_ex04_Aplicacao_This_Construtores
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }
        //Reaproveitando o Construtor Padrão
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }
        //Reaproveitando o Construtor Anterior

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

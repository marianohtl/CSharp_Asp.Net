using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap5_ex03_Alternativas_Iniciar_Valores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //O construtor é uma operação que possui o mesmo nome da classe
        //Podemos definir se ele vai receber obrigatoriamente parâmetros de entrada 
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        } //por padrão os atributos não declarados recebem 0


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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap5_ex05_Encapsulamento
{
    class Produto
    {
        //o encapsulamento no modo private impede que estes atributos sejam acessados / modificados por qualquer um
        //Quando trabalhamos com atributos privativos, usamos o _ na frente, por convenção
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(){
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        //Métodos Manuais Get e Set, para alteração de atributos
        //Vantagens - proteção, e este acesso por meio de métodos, 
        // podemos também colocar lógica nele, assegurando que estamos mantendo o estado consistente do objeto de acordo com a regra de negócio 
        //null == vazio
        
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if(_nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

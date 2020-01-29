using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap04Ex03
{
    class Produto
    {
        public string Nome;

        public double Preco;

        public int Quantidade;

        public double ValorTotalEmEstoque() {
            double Total = Quantidade * Preco;
            return Total;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity; 
            
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;

        }

        //Aqui iremos implementar uma operação ToString que é da classe Object
        //Faremos então uma sobreposição (por ele ser da classe Ojective
        //Abaixo temos a assinatura básica da função ToString
        //override indica que essa operação veio de outra classe
        public override string ToString()
        {
            //Aqui dentro colocamos a lógica de tranformar um produto em string   
            return Nome + " , R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " , "+ Quantidade+ " unidade, Total: R$"+ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

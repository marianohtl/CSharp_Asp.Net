using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap4_ex04
{
    class Funcionario
    {
        public string Nome;

        public double SalarioBruto;

        public double Imposto;

        public double SalarioLiquidoAum;

        public double SalarioLiquido()
        {
            return SalarioLiquidoAum = SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioLiquidoAum = SalarioLiquidoAum + (SalarioBruto * (porcentagem/100));
        }
        
        public override string ToString()
        {
            return Nome + " , R$" + SalarioLiquidoAum.ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}

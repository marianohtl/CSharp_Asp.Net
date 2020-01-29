using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap4ex05
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public string Avaliar()
        {
            double sobra, NotaFinal = Nota1 + Nota2 + Nota3;
            string resultado;
            if (NotaFinal < 60.00)
            {
                sobra = 60.00 - NotaFinal;
                resultado = "Reprovado!";
                return $"Nota Final: {NotaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n{resultado} \nFALTARAM: {sobra.ToString("F2", CultureInfo.InvariantCulture)} PONTOS"; 
            } else {
                resultado = "Aprovado!";
            }
            return $"Nota Final: {NotaFinal.ToString("F2", CultureInfo.InvariantCulture)} \n{resultado}";
        }




    }
}

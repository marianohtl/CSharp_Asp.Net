using System;
using System.Collections.Generic;
using System.Text;

namespace Cap4_ex07
{
    class ConversorDeMoedas
    {
        public static double Cotacao;

        public static double Dolares;

        public static double Converter()
        {
            double convertido;
            convertido = Dolares * Cotacao;
            convertido = convertido + (convertido * 0.06);
            return convertido;
        }
    }
}

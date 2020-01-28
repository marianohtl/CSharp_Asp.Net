using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo4
{
    class ex00
    {

        public void AreaTriangulo()
        {
            
            double a,b,c,p,areaX = 0.01, areaY = 0.01, cont=1;
              
            while(cont != 3)
            {
                Console.WriteLine($"Digite o lado A do {cont}º triângulo:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o lado B do {cont}º triângulo:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o lado C do {cont}º triângulo:");
                c = double.Parse(Console.ReadLine());
                p = (a + b + c) / 2.0;
                
                if (cont == 1)
                {
                    areaX = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }else if(cont == 2)
                {
                    areaY = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
                cont++;
            }

            Console.WriteLine($"A área de X = {areaX.ToString("F4")}");
            Console.WriteLine($"A área de Y = {areaY.ToString("F4")}");

            if (areaX > areaY)
            {
                Console.WriteLine("A maior área: X");
            }
            else
            {
                Console.WriteLine("A maior área: Y");
            }



        }
    }
}

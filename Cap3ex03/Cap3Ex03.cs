using System;
using System.Collections.Generic;
using System.Text;

namespace O.O.CSharpExercises
{
    class Cap3Ex03
    {
        public void CoordenadasWhile()
        {
            bool enquanto = false;
            while (enquanto != true)
            {

                double x, y;
                Console.WriteLine("Me diga a coordenada X: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Me diga a coordenada Y: ");
                y = double.Parse(Console.ReadLine());

                if (x == 0.0 || y == 0.0)
                {
                    enquanto = true;
                }
                else if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("Segundo Quadrante!");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("Primeiro Quadrante!");

                }
                else if (x > 0.0 && y < 0.0)
                {
                    Console.WriteLine("Quarto Quadrante!");
                }
                else if (x < 0.0 && y < 0.0)
                {
                    Console.WriteLine("Terceiro Quadrante!");
                }

            }


        }

        public void PostoGasolina()
        {
            Console.WriteLine("####################################");
            Console.WriteLine("Posto de Gasolina - Faça Seu Pedido");
            Console.WriteLine("####################################");
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");
            Console.WriteLine("####################################");

            int clienteAlcool = 0, clienteGasolina = 0, clienteDiesel = 0, pedido;
            bool terminar = false;

            while (terminar == false)
            {
                Console.WriteLine("Qual combustível tu quer?");
                pedido = int.Parse(Console.ReadLine());

                if (pedido == 4)
                {
                    Console.WriteLine("Muito Obrigado!");
                    Console.WriteLine($"Gasolina: {clienteGasolina}");
                    Console.WriteLine($"Álcool: {clienteAlcool}");
                    Console.WriteLine($"Diesel: {clienteDiesel}");

                    terminar = true;
                }
                else if (pedido == 1)
                {
                    clienteAlcool++;
                }
                else if (pedido == 2)
                {
                    clienteGasolina++;
                }
                else if (pedido == 3)
                {
                    clienteDiesel++;
                }

            }
        }

       }
}

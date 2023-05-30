/* 
Fazer um programa para ler os três coeficientes de uma equação do segundo grau. Usando a fórmula 
de Baskara, calcular e mostrar os valores das raízes x1 e x2 da equação com quatro casas decimais, 
conforme exemplo. Se a equação não possuir raízes reais, mostrar uma mensagem. 
*/

using System;
using System.Globalization;

namespace bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Coeficiente a: ");
            double a = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente b: ");
            double b = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente c: ");
            double c = Double.Parse(Console.ReadLine(), CI);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta < 0)
            {
                Console.WriteLine("Esta equação não possui raízes reais.");
            }
            else
            {
                Console.WriteLine("X1 = " + x1.ToString("F4", CI));
                Console.WriteLine("X2 = " + x2.ToString("F4", CI));
            }
            

        }
    }
}
/* 
Fazer um programa para ler três medidas A, B e C. Em seguida, calcular e mostrar (imprimir os dados 
com quatro casas decimais): 
a) a área do quadrado que tem lado A 
b) a área do triângulo retângulo que base A e altura B 
c) a área do trapézio que tem bases A e B, e altura C 
*/

using System;
using System.Globalization;

namespace medidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double A, B, C, areaq, areatri, areatra;

            Console.Write("Digite a medida A: ");
            A = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida B: ");
            B = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida C: ");
            C = Double.Parse(Console.ReadLine(), CI);

            areaq = Math.Pow(A, 2);
            areatri = A * B / 2;
            areatra = (A + B) * C / 2;

            Console.WriteLine("ÁREA DO QUADRADO: " + areaq.ToString("F4", CI));
            Console.WriteLine("ÁREA DO TRIÂNGULO: " + areatri.ToString("F4", CI));
            Console.WriteLine("ÁREA DO TRAPÉZIO: " + areatra.ToString("F4", CI));

        }
    }
}
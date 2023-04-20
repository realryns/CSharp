/* 
Fazer um programa para ler dois valores inteiros X e Y, e depois mostrar na tela o valor da soma destes 
números.  
*/

using System;
using System.Globalization;

namespace idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int X, Y, soma;

            Console.Write("Digite o valor de X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            Y = int.Parse(Console.ReadLine());

            soma = X + Y;

            Console.WriteLine("SOMA = " + soma);


        }
    }
}
/* Leia um valor inteiro X. Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, 
se for o caso. */

using System;

namespace soma_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor de X: ");
            int X = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
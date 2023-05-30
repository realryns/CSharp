/* Fazer um programa para ler um número natural N (valor máximo: 15), e depois calcular e mostrar o 
fatorial de N. */

using System;

namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N, fatorial;

            Console.Write("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());

            if (N == 0)
            {
                fatorial = 1;
            }
            else
            {
                fatorial = N;

                for (int i = N - 1; i > 0; i--)
                {
                    fatorial = fatorial * i;
                }
            }           

            Console.WriteLine("FATORIAL = {0}", fatorial);

        }
    }
}
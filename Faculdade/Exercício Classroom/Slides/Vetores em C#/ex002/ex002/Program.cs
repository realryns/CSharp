/* Escreva um algoritmo calcula a soma de todos os elementos de um
vetor com 10 números inteiros. O usuário deverá digitar todos os
elementos. */

using System;

namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int [10];
            int soma = 0;

            for (int i = 0; i < num.Length; i++)
            {                               
                num[i] = int.Parse(Console.ReadLine());
                soma += num[i];
            }

            Console.WriteLine("SOMA: {0}", soma);

        }
    }
}
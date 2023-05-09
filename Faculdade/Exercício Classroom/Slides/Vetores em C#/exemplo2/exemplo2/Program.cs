/* Construa um algoritmo que calcula a soma de todos os elementos
de um vetor de inteiros. */

using System;

namespace exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] N = {-32, 7, 15, -3, 19, 8, 3, 0, -1, 10};
            int soma = 0;

            for (int i = 0; i < N.Length; i++)
            {
                 soma += N[i];
            }            

            Console.WriteLine(soma);

        }
    }
}
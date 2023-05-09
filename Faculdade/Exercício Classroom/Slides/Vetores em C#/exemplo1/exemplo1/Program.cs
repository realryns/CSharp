/* Escreva um algoritmo encontra o menor elemento de um vetor com
10 elementos. Considere que o usuário fornecerá todos os
elementos, digitando-os pelo teclado. */

using System;

namespace exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] N = new int[10];
            int menor;

            for (int i = 0; i < N.Length; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }

            menor = N[0];

            for (int i = 0;i < N.Length; i++)
            {
                if (N[i] < menor)
                {
                    menor = N[i];
                }
            }

            Console.WriteLine(menor);

        }
    }
}
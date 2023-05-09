/* Escreva um algoritmo que, dados dois vetores U e V, calcula
U − V, ou seja, mostra todos os elementos de U que não estão
presentes em V. */

using System;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] U = {1, 3, 5, 7, 9, 11};
            int[] V = {2, 3, 5, 6, 9, 10};


            for (int i = 0; i < U.Length; i++)
            {
                for (int j = 0; j < V.Length; j++)
                {
                    if (U[i] == V[j])
                    {
                        Console.WriteLine(U[i]);
                    }
                }
            }

        }
    }
}
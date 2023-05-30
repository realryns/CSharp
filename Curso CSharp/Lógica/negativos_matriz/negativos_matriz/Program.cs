/* Ler dois números M e N (máximo = 10), e depois ler uma matriz MxN de números inteiros, conforme 
exemplo. Em seguida, mostrar na tela somente os números negativos da matriz. */

using System;
using System.Globalization;

namespace negativos_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Qual a quatidade de linhas da matriz? ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            int N = int.Parse(Console.ReadLine());

            int[,] num = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [{0}, {1}]: ", i, j);
                    num[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Negativos
            Console.WriteLine("VALORES NEGATIVOS: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (num[i, j] < 0)
                    {
                        Console.WriteLine(num[i, j]);
                    }
                }
            }

        }
    }
}
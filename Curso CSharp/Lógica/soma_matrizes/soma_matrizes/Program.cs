/* Fazer um programa para ler duas matrizes de números inteiros A e B, contendo de M linhas e N colunas 
cada (M e N máximo = 10). Depois, gerar uma terceira matriz C onde cada elemento desta é a soma 
dos elementos correspondentes das matrizes originais. Imprimir na tela a matriz gerada. */

using System;

namespace soma_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantas linhas vai ter cada matriz? ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter cada matriz? ");
            int N = int.Parse(Console.ReadLine());

            //MATRIZ A
            int[,] A = new int[M, N];
            Console.WriteLine("Digite os valores da matriz A: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [{0}, {1}]: ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //MATRIZ B
            int[,] B = new int[M, N];
            Console.WriteLine("Digite os valores da matriz B: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [{0}, {1}]: ", i, j);
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //MATRIZ C
            int[,] C = new int[M, N];
            Console.WriteLine("MATRIZ SOMA: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }                

        }
    }
}
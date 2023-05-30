/* Fazer um programa para ler dois números inteiros M e N (máximo = 10). Em seguida, ler uma matriz 
de M linhas e N colunas contendo números reais. Gerar um vetor de modo que cada elemento do vetor 
seja a soma dos elementos da linha correspondente da matriz. Mostrar o vetor gerado. */

using System;
using System.Globalization;

namespace soma_linhas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            int N = int.Parse(Console.ReadLine());

            double[,] matriz = new double[M, N];
            double[] soma = new double[M];

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine("Digite os elementos da {0}a linha: ", i + 1);
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = Double.Parse(Console.ReadLine(), CI);
                    soma[i] += matriz[i, j];
                }
            }

            Console.WriteLine("VETOR GERADO: ");
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(soma[i].ToString("F1", CI));
            }

        }
    }
}
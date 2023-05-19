/* Ler um inteiro N (máximo = 10) e uma matriz quadrada de ordem N 
contendo números inteiros. Mostrar a soma dos elementos acima da 
diagonal principal. Um exemplo de números acima da diagonal 
principal é mostrado ao lado (no caso as células com fundo cinza). */

using System;

namespace acima_diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a ordem da matriz? ");
            int N = int.Parse(Console.ReadLine());

            int[,] num = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [{0}, {1}]: ", i, j);
                    num[i, j] = int.Parse(Console.ReadLine());

                }
            }

            //SOMA
            int soma = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i < j)
                    {
                        soma += num[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = {0}", soma);
        }
    }
}
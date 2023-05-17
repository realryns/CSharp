/* Fazer um programa para ler um número inteiro N (máximo = 10) e uma matriz quadrada de ordem N 
contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores 
negativos da matriz. */

using System;

namespace diagonal_negativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int negativos = 0, diagonal;

            Console.Write("Qual a ordem da matriz? ");
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];
            
            for ( int i = 0; i < N; i++ )
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [{0}, {1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] < 0 )
                    {
                        negativos++;
                    }
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE NEGATIVOS: {0}", negativos);
            

        }
    }
}
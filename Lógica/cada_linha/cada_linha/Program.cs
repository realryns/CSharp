/* Ler um inteiro N e uma matriz quadrada de ordem N (máximo = 10). Mostrar qual o maior elemento 
de cada linha. Suponha não haver empates. */

using System;
using System.Globalization;

namespace cada_linha
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a ordem da matriz? ");
            int M = int.Parse(Console.ReadLine());           

            int[,] num = new int[M, M];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("Elemento [{0}, {1}]: ", i, j);
                    num[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Maior
            int maior;
            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");
            for (int i = 0; i < M; i++)
            {
                maior = num[i, 0];
                for (int j = 0; j < M; j++)
                {                   
                    if (num[i, j] > maior)
                    {
                        maior = num[i, j];
                    }                                       
                }
                Console.WriteLine(maior);
            }

        }
    }
}
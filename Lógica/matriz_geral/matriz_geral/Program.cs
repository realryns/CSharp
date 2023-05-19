/* Ler uma matriz quadrada de ordem N (máximo = 10), contendo números reais. Em seguida, fazer as 
seguintes ações: 
a) calcular e imprimir a soma de todos os elementos positivos da matriz. 
b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha. 
c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna. 
d) imprimir os elementos da diagonal principal da matriz. 
e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir 
a matriz alterada. */

using System;
using System.Globalization;

namespace matriz_geral
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double somaPositivos = 0;
            
            Console.Write("Qual a ordem da matriz? ");
            int N = int.Parse(Console.ReadLine());

            double[,] num = new double[N, N];

            //SOMA POSITIVOS
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [{0}, {1}]: ", i, j);
                    num[i, j] = Double.Parse(Console.ReadLine(), CI);
                    if (num[i, j] >= 0)
                    {
                        somaPositivos += num[i, j];
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("\nSOMA DOS POSITIVOS: {0}", somaPositivos.ToString("F1", CI));

            //ESCOLHA DE LINHAS
            Console.Write("\nEscolha uma linha: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++)
            {
                Console.Write(num[linha, j].ToString("F1", CI) + " ");
            }

            //ESCOLHA DE COLUNAS
            Console.Write("\n\nEscolha uma coluna: ");
            int coluna = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(num[i, coluna].ToString("F1", CI) + " ");
            }

            //DIAGONAL PRINCIPAL
            Console.Write("\n\nDIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; ++i)
            {
                Console.Write(num[i, i].ToString("F1", CI) + " ");
            }

            //MATRIZ ALTERADA
            Console.WriteLine("\n\nMATRIZ ALTERADA: ");
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; j++)
                {
                    if (num[i, j] < 0)
                    {
                        num[i, j] = Math.Pow(num[i, j], 2);
                    }
                    Console.Write(num[i, j].ToString("F1", CI) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
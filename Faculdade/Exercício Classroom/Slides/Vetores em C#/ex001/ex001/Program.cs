/* Escreva um algoritmo que, dado um número inteiro x e um vetor
V de números inteiros, verifica se x está presente em V. */

using System;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] V = { -32, 7, 15, -3, 19, 8, 3, 0, -1, 10 };
            int dentro = 0;

            Console.Write("Digite o valor de X: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < V.Length; i++)
            {
                if (X == V[i])
                {
                    dentro = 1;
                    Console.WriteLine("{0} está incluso no vetor.", X);

                }
            }

            if (dentro == 0)
            {
                Console.WriteLine("{0} não está incluso no vetor.", X);
            }        

        }
    }
}
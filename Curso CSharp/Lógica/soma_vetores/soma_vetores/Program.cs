/* Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um 
terceiro vetor C onde cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima 
o vetor C gerado. */

using System;

namespace soma_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos valores vai ter cada vetor? ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            // Vetor A
            Console.WriteLine("Digite os valores do vetor A: ");
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            // Vetor B
            Console.WriteLine("Digite os valores do vetor B: ");
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }

            //Vetor C           
            for (int i = 0;i < N; i++)
            {
                C[i] = A[i] + B[i];
            }

            //Saída
            Console.WriteLine("VETOR RESULTANTE: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(C[i]);
            }

        }
    }
}
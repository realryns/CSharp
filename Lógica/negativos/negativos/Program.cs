/* Faça um programa que leia um número inteiro positivo N (máximo = 10) e depois N números inteiros 
e armazene-os em um vetor. Em seguida, mostrar na tela todos os números negativos lidos. */

using System;

namespace negativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Quantos números você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int[] vetor = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NÚEMROS NEGATIVOS: ");
            
            for (int i = 0;i < N; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }

        }
    }
}
/* Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na 
tela todos os números pares, e também a quantidade de números pares. */

using System;

namespace numeros_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Quantos números você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int[] num = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine();
            Console.WriteLine("NÚMEROS PARES: ");          
            for (int i = 0; i < N; i++)
            {
                if ((num[i] % 2 == 0) && (num[i] != 0))
                {
                    Console.Write("{0} ", num[i]);
                }
            }

            int cont = 0;
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (num[i] % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine("QUANTIDADE DE PARES = {0}", cont);

        }
    }
}
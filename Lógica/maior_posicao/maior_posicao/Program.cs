/*Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela 
o maior número do vetor (supor não haver empates). Mostrar também a posição do maior elemento, 
considerando a primeira posição como 0 (zero).*/

using System;

namespace maior_posicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            
            Console.Write("Quanto numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int[] num = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                num[i] = int.Parse(Console.ReadLine());              
            }
            
            for (int i = 0;i < N;i++)
            {

            }

        }
    }
}
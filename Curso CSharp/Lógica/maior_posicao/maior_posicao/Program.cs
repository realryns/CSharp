/*Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela 
o maior número do vetor (supor não haver empates). Mostrar também a posição do maior elemento, 
considerando a primeira posição como 0 (zero).*/

using System;
using System.Globalization;

namespace maior_posicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Quanto numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            double[] num = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                num[i] = Double.Parse(Console.ReadLine(), CI);              
            }

            double maior = num[0];
            int pos = 0;
            for (int i = 0;i < N;i++)
            {
                if (num[i] > maior)
                {
                    maior = num[i];
                    pos = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("MAIOR VALOR = {0}", maior.ToString("F1", CI));
            Console.WriteLine("POSIÇÃO DO MAIOR VALOR = {0}", pos);

        }
    }
}
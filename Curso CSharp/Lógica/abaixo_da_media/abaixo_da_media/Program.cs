/* Fazer um programa para ler um número inteiro N e depois um vetor de N números reais. Em seguida, 
mostrar na tela a média aritmética de todos elementos com três casas decimais. Depois mostrar todos 
os elementos do vetor que estejam abaixo da média, com uma casa decimal cada. */

using System;
using System.Globalization;

namespace abaixo_da_media
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Quantos elementos vai ter o vetor? ");
            int N = int.Parse(Console.ReadLine());
            double[] num = new double[N];
            double media, soma = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                num[i] = Double.Parse(Console.ReadLine(), CI);
                soma += num[i];
            }

            media = soma / N;

            Console.WriteLine();
            Console.WriteLine("MEDIA DO VETOR = {0}", media.ToString("F3", CI));
            Console.WriteLine("ELEMENTOS ABAIXO DA MÉDIA: ");
            for (int i = 0; i < N; i++)
            {
                if (num[i] < media)
                {
                    Console.WriteLine(num[i].ToString("F1", CI));
                }               
            }
            
        }
    }
}
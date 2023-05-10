/* Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida: 
- Imprimir todos os elementos do vetor 
- Mostrar na tela a soma e a média dos elementos do vetor */

using System;
using System.Globalization;

namespace soma_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            double[] vetor = new double[N];

            double soma = 0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = Double.Parse(Console.ReadLine(), CI);
                soma += vetor[i];
            }

            Console.Write("VALORES = ");
            for (int i = 0; i < N; i++)
            {                
                Console.Write(" ");
                Console.Write(vetor[i].ToString("F1", CI));
            }

            double media = soma / N;

            Console.WriteLine();
            Console.WriteLine("SOMA  = {0}", soma.ToString("F2", CI));
            Console.WriteLine("MÉDIA = {0}", media.ToString("F2", CI));
        }

    }
}
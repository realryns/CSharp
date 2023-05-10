/* Fazer um programa para ler nome, idade e altura de N pessoas, conforme exemplo. Depois, mostrar na 
tela a altura média das pessoas, e mostrar também a porcentagem de pessoas com menos de 16 anos, 
bem como os nomes dessas pessoas caso houver. */

using System;
using System.Globalization;

namespace alturas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
          
            int contnome = 0;
            double altura, somaaltura = 0, media;

            Console.Write("Quantas pessoas serão digitadas? ");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            string[] menores = new string[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Dados da {0}a pessoa: ", i+1);
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                altura = Double.Parse(Console.ReadLine(), CI);

                somaaltura += altura;
                
            }

            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    contnome++;
                }

            }
            
            media = somaaltura / N;

            Console.WriteLine();
            Console.WriteLine("Altura média: {0}", media.ToString("F2", CI));
            Console.WriteLine("Pessoas com menos de 16 anos: {0}%", (100 * contnome / N).ToString("F1", CI));

            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    Console.WriteLine(nomes[i]);
                }
            }

        }

    }
}
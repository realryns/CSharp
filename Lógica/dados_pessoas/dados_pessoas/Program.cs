/* Tem-se um conjunto de dados contendo a altura e o gênero (M, F) de N pessoas. Fazer um programa 
que calcule e escreva a maior e a menor altura do grupo, a média de altura das mulheres, e o número 
de homens. */

using System;
using System.Globalization;

namespace dados_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantas pessoas serão digitadas? ");
            int N = int.Parse(Console.ReadLine());
            char[] gen = new char[N];
            double[] altura = new double[N];
            int contM = 0, contF = 0;

            //Entrada de dados
            for (int i = 0; i < N; i++)
            {
                Console.Write("Altura da {0}a pessoa: ", i + 1);
                altura[i] = Double.Parse(Console.ReadLine(), CI);
                Console.Write("Gênero da {0}a pessoa: ", i + 1);
                gen[i] = char.Parse(Console.ReadLine());
            }

            //Maior e menor altura
            double maior = altura[0], menor = altura[0];
            for (int i = 0; i < N; i++)
            {
                if (altura[i] > maior)
                {
                    maior = altura[i];
                }
                else if (altura[i] < menor)
                {
                    menor = altura[i];
                }
            }

            //Contagem de Gêneros
            for (int i = 0; i < N; i++)
            {
                if (gen[i] == 'M')
                {
                    contM++;
                }
                else
                {
                    contF++;
                }
            }

            //Média alturas
            double soma = 0;
            for (int i = 0; i < N; i++)
            {
                if (gen[i] == 'F')
                {
                    soma += altura[i];
                }
            }
            double media = soma / contF;

            Console.WriteLine("Menor altura = {0}", menor.ToString("F2", CI));
            Console.WriteLine("Maior altura = {0}", maior.ToString("F2", CI));
            Console.WriteLine("Média das alturas das mulheres = {0}", media.ToString("F2", CI));
            Console.WriteLine("Número de homens = {0}", contM);

        }
    }
}
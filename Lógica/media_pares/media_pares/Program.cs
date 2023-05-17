/* Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média 
aritmética somente dos números pares lidos, com uma casa decimal. Se nenhum número par for 
digitado, mostrar a mensagem "NENHUM NUMERO PAR" */

using System;
using System.Globalization;

namespace medias_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor? ");
            int N = int.Parse(Console.ReadLine());
            int num, contpares = 0;
            double media, soma = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine(), CI);
                if (num % 2 == 0)
                {
                    soma += num;
                    contpares++;
                }
            }

            if (contpares == 0)
            {
                Console.WriteLine("NENHUM NÚMERO PAR");
            }
            else
            {
                media = soma / contpares;
                Console.WriteLine("MÉDIA DOS PARES = {0}", media.ToString("F1", CI));
            }

        }
    }
}
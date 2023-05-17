/* Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Os nomes 
devem ser armazenados em um vetor, e as idades em um outro vetor. Depois, mostrar na tela o nome 
da pessoa mais velha. */

using System;

namespace mais_velho
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Quantos pessoas você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            int[] idade = new int[N];
            int maior = idade[0];
            string maisvelho = nome[0];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Dados da {0}a pessoa: ", i+1);
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                if (idade[i] > maior)
                {
                    maior = idade[i];
                    maisvelho = nome[i];
                }
            }

            Console.WriteLine("PESSOA MAIS VELHA: {0}", maisvelho);

        }
    }
}
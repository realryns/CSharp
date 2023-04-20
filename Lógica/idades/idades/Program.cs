/* 
Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os 
nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo. 
*/

using System;
using System.Globalization;

namespace idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome1, nome2;
            int idade1, idade2;
            double media;

            Console.Write("Digite o nome da primeira pessoa: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2.0;

            Console.WriteLine("DADOS DA PRIMEIRA PESSOA: ");
            Console.WriteLine("NOME: " + nome1);
            Console.WriteLine("IDADE: " + idade1);
            Console.WriteLine("DADOS DA SEGUNDA PESSOA: ");
            Console.WriteLine("NOME: " + nome2);
            Console.WriteLine("IDADE: " + idade2);
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString(CI) + " anos.");




        }
    }
}
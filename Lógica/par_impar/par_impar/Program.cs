/* Leia um valor inteiro N. Este valor será a quantidade de números inteiros que serão lidos em seguida. 
Para cada valor lido, mostre uma mensagem dizendo se este valor lido é PAR ou IMPAR, e também 
se é POSITIVO ou NEGATIVO. No caso do valor ser igual a zero (0), seu programa deverá imprimir 
apenas NULO. */

using System;

namespace par_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.Write("Quantos números você vai digitar? : ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine("NULO");
                }
                else if ((num > 0) && (num % 2 == 0))
                {
                    Console.WriteLine("PAR POSITIVO");
                }
                else if ((num > 0) && (num % 2 != 0))
                {
                    Console.WriteLine("ÍMPAR POSITIVO");
                }
                else if ((num < 0) && (num % 2 == 0))
                {
                    Console.WriteLine("PAR NEGATIVO");
                }
                else if ((num < 0) && (num % 2 != 0))
                {
                    Console.WriteLine("ÍMPAR NEGATIVO");
                }
            }   

        }
    }
}
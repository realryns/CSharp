/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo. */

using System;

namespace dentro_fora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, dentro = 0, fora = 0;

            Console.Write("Quantos números você vai digitar? : ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                if ((num >= 10) && (num <= 20))
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }              
            }

            Console.WriteLine("{0} DENTRO", dentro);
            Console.WriteLine("{0} FORA", fora);

        }
    }
}
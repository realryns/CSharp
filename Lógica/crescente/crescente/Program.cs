/* 
Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma 
mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente. O 
programa deve finalizar quando forem digitados dois valores iguais.  
*/

using System;

namespace crescente
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite dois números: ");
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            while (X != Y)
            {

                if (X > Y)
                {
                    Console.WriteLine("DECRESCENTE!");
                }
                else
                {
                    Console.WriteLine("CRESCENTE!");
                }

                Console.WriteLine("Digite outros dois números: ");
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());

            }

        }
    }
}
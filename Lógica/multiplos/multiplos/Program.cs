using System;
using System.Globalization;

namespace multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, temp;

            Console.WriteLine("Digite dois números inteiros: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            
            if (num2 > num1)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            if (num1 % num2 == 0)
            {
                Console.WriteLine("São mútiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}
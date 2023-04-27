using System;
using System.Globalization;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double F, C, temp;

            Console.Write("Você irá digitar a temperatura em qual escala (C/F)? ");
            char escala = char.Parse(Console.ReadLine());

            if (escala == 'F')
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                F = Double.Parse(Console.ReadLine(), CI);
                temp = 5 * (F - 32) / 9;
                Console.WriteLine("Temperatura equivalente em Celsius: {0}", temp.ToString("F2", CI));
            }
            else
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = Double.Parse(Console.ReadLine(), CI);
                temp = 9 * C / 5 + 32;
                Console.WriteLine("Temperatura equivalente em Celsius: {0}", temp.ToString("F2", CI));
            }

        }
    }
}
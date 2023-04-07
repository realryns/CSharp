using System;

namespace beecrowd1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            double media = (A * 2 + B * 3 + C * 5) / 10;

            Console.WriteLine($"MEDIA = {media:F1}");

        }
    }
}
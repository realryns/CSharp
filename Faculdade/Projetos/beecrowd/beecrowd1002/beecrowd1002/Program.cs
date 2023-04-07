using System;

namespace beecrowd1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double r = double.Parse(Console.ReadLine());
            double a = n * Math.Pow(r, 2);

            Console.WriteLine($"A={a:F4}");



        }
    }
}
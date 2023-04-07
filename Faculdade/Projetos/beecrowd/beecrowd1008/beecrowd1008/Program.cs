using System;

namespace beecrowd1008
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = Convert.ToDouble(Console.ReadLine());

            double salario = valor * horas;
            salario.ToString("C");

            Console.WriteLine($"NUMBER = {num}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");

        }
    }
}
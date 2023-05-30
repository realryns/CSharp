using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double valor = 50.00;

            Console.Write("Digite a quantidade de minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            if (minutos > 100)
            {
                valor += (minutos - 100) * 2.00;
            }

            Console.WriteLine("Valor a pagar: R$ {0}", valor.ToString("F2", CI));
        }
    }
}
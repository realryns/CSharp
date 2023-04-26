using System;
using System.Globalization;

namespace troco_verificado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            double glicose;
            string classi;

            Console.Write("Digite a medida da glicose: ");
            glicose = Double.Parse(Console.ReadLine(), CI);
            
            if (glicose <= 100)
            {
                classi = "normal";                   
            }
            else if (glicose <= 140)
            {
                classi = "elevado";
            }
            else
            {
                classi = "diabetes";
            }
            Console.Write("Classificação: {0}", classi);

        }
    }
}
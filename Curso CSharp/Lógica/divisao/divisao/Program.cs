/* Escreva um algoritmo que leia dois números e imprima o resultado da divisão do primeiro pelo 
segundo. Caso não for possível, mostre a mensagem “DIVISAO IMPOSSIVEL”. */

using System;
using System.Globalization;

namespace divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double numerador, denominador, res;

            Console.Write("Quantos casos você vai digitar? ");
            int casos = int.Parse(Console.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                Console.Write("Entre com o numerador: ");
                numerador = Double.Parse(Console.ReadLine(), CI);
                Console.Write("Entre com o denominador: ");
                denominador = Double.Parse(Console.ReadLine(), CI);

                if (denominador != 0)
                {
                    res = numerador / denominador;
                    Console.WriteLine("DIVISÃO = {0}", res.ToString("F2", CI));
                }
                else
                {
                    Console.WriteLine("DIVISÃO IMPOSSÍVEL!");
                }
            }

        }
    }
}
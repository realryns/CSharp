/* Leia 2 valores inteiros X e Y (em qualquer ordem). A seguir, calcule e mostre a soma dos números 
impares entre eles. */

using System;

namespace soma_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite dois números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 < num1)
            {
               int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            int soma = 0;
            for (int i = num1 + 1; i < num2; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("SOMA DOS ÍMPARES = {0}", soma);

        }
    }
}
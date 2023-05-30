/* Leia um valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de 
teste consiste de 3 valores reais, para os quais você deverá calcular e mostrar a média ponderada, sendo 
que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5. Vale lembrar 
que a média ponderada é a soma de todos os valores multiplicados pelo seu respectivo peso, dividida 
pela soma dos pesos. */

using System;
using System.Globalization;

namespace media_ponderada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double num1, num2, num3, media;

            Console.Write("Quantos casos você vai digitar? ");
            int casos = int.Parse(Console.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                Console.WriteLine("Digite 3 números: ");
                num1 = Double.Parse(Console.ReadLine(), CI);
                num2 = Double.Parse(Console.ReadLine(), CI);
                num3 = Double.Parse(Console.ReadLine(), CI);

                media = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
                Console.WriteLine("MÉDIA = {0}", media.ToString("F1", CI));
            }           

        }
    }
}
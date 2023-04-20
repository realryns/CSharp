/* 
Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor 
da área, perímetro e diagonal deste retângulo, com quatro casas decimais, conforme exemplos.
*/

using System;
using System.Globalization;

namespace retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double baset, altura, area, perimetro, diagonal;

            Console.Write("BASE: ");
            baset = Double.Parse(Console.ReadLine(), CI);
            Console.Write("ALTURA: ");
            altura = Double.Parse(Console.ReadLine(), CI);

            area = baset * altura;
            perimetro = 2 * (baset + altura);
            diagonal = Math.Sqrt(Math.Pow(baset, 2) + Math.Pow(altura, 2));

            Console.WriteLine("ÁREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));

        }
    }
}
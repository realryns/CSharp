/* 
Fazer um programa para ler o valor "r" do raio de um círculo, e depois mostrar o valor da área do 
círculo com três casas decimais. A fórmula da área do círculo é a seguinte: 𝑎𝑟𝑒𝑎 = 𝜋. 𝑟
*/

using System;
using System.Globalization;

namespace circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double raio, area;

            Console.Write("Digite o valor do raio do círculo: ");
            raio = Double.Parse(Console.ReadLine(), CI);

            area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("ÁREA = " + area.ToString("F3", CI));
        }
    }
}
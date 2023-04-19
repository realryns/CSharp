using System;
using System.Globalization;

/* 
Problema "terreno" 
Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma 
casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida, 
o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com 
duas casas decimais, conforme exemplo. 
*/


namespace terreno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, comprimento, area, valor, preco;

            Console.Write("LARGURA DO RETÂNGULO: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("COMPRIMENTO DO RETÂNGULO: ");
            comprimento = double.Parse(Console.ReadLine(), CI);
            Console.Write("VALOR DO METRO QUADRADO: ");
            valor = double.Parse(Console.ReadLine(), CI);

            area = largura * comprimento;
            preco = valor * area;

            Console.WriteLine("ÁREA DO TERRENO: " + area.ToString("F2", CI));
            Console.WriteLine("PREÇO DO TERRENO: R$ " + preco.ToString("F2", CI));
        }
    }
}
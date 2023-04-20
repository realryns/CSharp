/* 
Fazer um programa para ler a distância total (em km) percorrida por um carro, bem como o total de 
combustível gasto por este carro ao percorrer tal distância. Seu programa deve mostrar o consumo 
médio do carro, com três casas decimais. 
*/

using System;
using System.Globalization;

namespace consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double distancia, combustivel, consumo;

            Console.Write("Distância percorrida: ");
            distancia = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Combustível gasto: ");
            combustivel = Double.Parse(Console.ReadLine(), CI);

            consumo = distancia / combustivel;
            Console.WriteLine("Consumo médio: " + consumo.ToString("F3", CI) + " Km/l");    

        }
    }
}
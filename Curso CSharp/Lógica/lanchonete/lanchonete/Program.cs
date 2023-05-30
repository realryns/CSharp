using System;
using System.Globalization;

namespace lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int codigo, quantidade;
            double preco, total;

            Console.Write("Código do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());


            if (codigo == 1)
            {
                preco = 5.00;
            }
            else if (codigo == 2)
            {
                preco = 3.50;
            }
            else if (codigo == 3)
            {
                preco = 4.80;
            }
            else if (codigo == 4)
            {
                preco = 8.90;
            }
            else
            {
                preco = 7.32;
            }

            total = preco * quantidade;

            Console.WriteLine("Vaor a pagar: R$ {0}", total.ToString("F2", CI));

        }
    }
}
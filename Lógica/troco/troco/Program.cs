/* 
Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia. 
O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto, 
e o valor em dinheiro dado pelo cliente (suponha que haja dinheiro suficiente). Seu programa deve 
mostrar o valor do troco a ser devolvido ao cliente.   
*/

using System;
using System.Globalization;

namespace idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double preco, recebido, troco;
            int quantidade;

            Console.Write("Preço unitário do produto: R$ ");
            preco = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: R$ ");
            recebido = Double.Parse(Console.ReadLine(), CI);

            troco = recebido - preco * quantidade;

            Console.WriteLine("TROCO = R$ " + troco.ToString("F2", CI));

        }
    }
}
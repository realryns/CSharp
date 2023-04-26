using System;
using System.Globalization;

namespace troco_verificado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double preco, valor, recebido, troco, faltante;
            int quantidade;

            Console.Write("Preço unitário do produto: ");
            preco = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido R$: ");
            recebido = Double.Parse(Console.ReadLine(), CI);

            valor = preco * quantidade;

            if (recebido < valor)
            {
                faltante = valor - recebido;
                Console.Write("DINHEIRO INSUFICIENTE. FALTAM {0} REAIS", faltante.ToString("F2", CI));
            }
            else
            {
                troco = recebido - preco * quantidade;
                Console.WriteLine("TROCO: R$ {0}", troco.ToString("F2", CI));
            }
            
        }
    }
}
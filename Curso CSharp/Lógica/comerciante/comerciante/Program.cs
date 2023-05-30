/* Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, 
mandou digitar um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de 
venda das mesmas. Fazer um programa que leia tais dados e determine e escreva quantas mercadorias 
proporcionaram: */

using System;
using System.Globalization;

namespace comerciante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            string nome;
            double lucrototal, totalcompra = 0, totalvenda = 0;
            int abaixo = 0, entre = 0, acima = 0;

            Console.Write("Serão digitados dados de quantos produtos? ");
            int N = int.Parse(Console.ReadLine());

            double[] compra = new double[N];
            double[] venda = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Produto {0}", i+1);
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Preço de compra: ");
                compra[i] = Double.Parse(Console.ReadLine(), CI);
                Console.Write("Preço de venda: ");
                venda[i] = Double.Parse(Console.ReadLine(), CI);

                totalcompra += compra[i];
                totalvenda += venda[i];
            }

            for (int i = 0; i < N; i++)
            {
                if (venda[i] < compra[i] * 1.1)
                {
                    abaixo++;
                }
                else if (venda[i] <= compra[i] * 1.2)
                {
                    entre++;
                }
                else
                {
                    acima++;
                }
            }

            lucrototal = totalvenda - totalcompra;

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO: ");
            Console.WriteLine("Lucro abaixo de 10%: {0}", abaixo);
            Console.WriteLine("Lucro entre 10% e 20%: {0}", entre);
            Console.WriteLine("Lucro acima de 20%: {0}", acima);
            Console.WriteLine("Valor total de compra: R$ {0}", totalcompra.ToString("F2", CI));
            Console.WriteLine("Valor total de venda: R$ {0}", totalvenda.ToString("F2", CI));
            Console.WriteLine("Lucro total: R$ {0}", lucrototal.ToString("F2", CI));

        }
    }
}
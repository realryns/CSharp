/* Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para 
organizar os experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano, 
quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada. Este 
laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas 
informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia 
utilizada e a quantidade de cobaias utilizadas em cada experimento. Faça um programa que leia um 
valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso de teste contém um 
inteiro que representa a quantidade de cobaias utilizadas e uma letra ('C', 'R' ou 'S'), indicando o tipo 
de cobaia (R:Rato S:Sapo C:Coelho). Apresente o total de cobaias utilizadas, o total de cada tipo de 
cobaia utilizada e o percentual de cada uma em relação ao total de cobaias utilizadas, sendo que o 
percentual deve ser apresentado com dois dígitos após o ponto. 
 */

using System;
using System.Globalization;

namespace experiencias
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            int casos, quantidade, coelhos = 0, sapos = 0, ratos = 0;
            double total = 0;
            char tipo;

            Console.Write("Quantos casos de teste serão digitados? ");
            casos = int.Parse(Console.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                quantidade = int.Parse(Console.ReadLine());

                Console.Write("Tipo de cobaia: ");
                tipo = char.Parse(Console.ReadLine());

                if (tipo == 'C')
                {
                    coelhos += quantidade;
                }
                else if (tipo == 'S')
                {
                    sapos += quantidade;
                }
                else
                {
                    ratos += quantidade;
                }

                total += quantidade;
            }

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO FINAL: ");
            Console.WriteLine("Total : {0} cobaias", total);
            Console.WriteLine("Total de coelhos: {0}", coelhos);
            Console.WriteLine("Total de ratos: {0}", ratos);
            Console.WriteLine("Total de sapos: {0}", sapos);
            Console.WriteLine("Percentual de coelhos: {0}", (coelhos * 100 / total).ToString("F2", CI));
            Console.WriteLine("Percentual de ratos: {0}", (ratos * 100 / total).ToString("F2", CI));
            Console.WriteLine("Percentual de sapos: {0}", (sapos * 100 / total).ToString("F2", CI));

        }
    }
}
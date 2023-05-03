/* 
Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um 
indivíduo. O último dado, que não entrará nos cálculos, contém um valor de idade negativa. Calcular 
e imprimir a idade média deste grupo de indivíduos. Se for entrado um valor negativo na primeira vez, 
mostrar a mensagem "IMPOSSIVEL CALCULAR". 
*/

using System;
using System.Globalization;

namespace crescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.WriteLine("Digite as idades: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("IMPOSSÍVEL CALCULAR!");
            }
            else
            {
                double cont = 0;
                double soma = 0;

                while (num >= 0)
                {
                    soma = soma + num;
                    cont++;
                    num = int.Parse(Console.ReadLine());
                }
                
                double media = soma / cont;
                Console.WriteLine("MÉDIA = {0}", media.ToString("F2", CI));

            }

        }
    }
}
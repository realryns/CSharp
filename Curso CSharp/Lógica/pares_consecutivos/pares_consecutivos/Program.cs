/* 
O programa deve ler um valor inteiro X indefinidas vezes. (O programa irá parar quando o valor de X 
for igual a 0). Para cada X lido, imprima a soma dos 5 pares consecutivos a partir de X, inclusive o X 
, se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 
4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a 
soma de 12+14+16+18+20.    
*/

using System;

namespace pares_consecutivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma = 0, num;

            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                
                if (num % 2 == 0)
                {
                    soma = 5 * num + 20;
                }
                else
                {
                    num++;
                    soma = 5 * num + 20;
                }

                Console.WriteLine("SOMA = {0}", soma);
                Console.Write("Digite um número inteiro: ");
                num = int.Parse(Console.ReadLine());

            }

        }
    }
}

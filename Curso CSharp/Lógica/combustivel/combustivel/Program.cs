/* 
Um posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. 
Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 
1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 
4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o 
código informado for o número 4, devendo então mostrar a mensagem "MUITO OBRIGADO", bem 
como as quantidades de cada combustível.   
*/

using System;

namespace validacao_de_nota
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int alcool = 0, gasolina = 0, diesel = 0, num;

            Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
            num = int.Parse(Console.ReadLine());

           while (num != 4)
            {
                if (num == 1)
                {
                    alcool++;
                }
                else if (num == 2)
                {
                    gasolina++;
                } 
                else if (num == 3)
                {
                    diesel++;
                }

                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                num = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: {0}", alcool);
            Console.WriteLine("Gasolina: {0}", gasolina);
            Console.WriteLine("Diesel: {0}", diesel);

        }
    }
}

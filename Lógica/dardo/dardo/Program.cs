/* 
No arremesso de dardo, o atleta tem três chances para lançar o dardo à maior distância que conseguir. 
Você deve criar um programa para, dadas as medidas das três tentativas de lançamento, informar qual 
foi a maior. 
*/

using System;
using System.Globalization;

namespace dardo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, maior;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as três distâncias: ");
            A = Double.Parse(Console.ReadLine(), CI);
            B = Double.Parse(Console.ReadLine(), CI);
            C = Double.Parse(Console.ReadLine(), CI);

            if ((A > B) && (A > C))
            {
                maior = A;        
            }
            else if (B > C)
            {
                maior = B;
            }
            else
            {
                maior = C;
            }

            Console.WriteLine("MAIOR DISTÂNCIA: {0}", maior.ToString("F2", CI));

        }
    }
}
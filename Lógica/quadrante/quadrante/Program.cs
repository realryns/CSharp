/* 
Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no 
sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence (Q1, Q2, Q3 ou Q4). O 
algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem 
escrever mensagem alguma). 
*/

using System;

namespace quadrante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pos;
            
            Console.WriteLine("Digite os valores das coordenadas X e Y: ");
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            
            while ((X != 0) && (Y != 0))
            {
                if ((X > 0) && (Y > 0))
                {
                    pos = "Q1";
                }
                else if ((X < 0) && (Y > 0))
                {
                    pos = "Q2";
                }
                else if ((Y < 0) && (X < 0))
                {
                    pos = "Q3";
                }
                else
                {
                    pos = "Q4";
                }

                Console.WriteLine("QUADRANTE {0}", pos);
                Console.WriteLine("Digite os valores das coordenadas X e Y: ");
                X = double.Parse(Console.ReadLine());
                Y = double.Parse(Console.ReadLine());

            }

        }
    }
}
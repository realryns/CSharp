/* 
Leia os valores das coordenadas X e Y de um ponto no plano 
cartesiano. A seguir, determine qual o quadrante ao qual pertence o 
ponto (Q1, Q2, Q3 ou Q4). Se o ponto estiver na origem, escreva a 
mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva 
“Eixo X” ou “Eixo Y”, conforme for a situação.   
*/

using System;
using System.Globalization;

namespace consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double X, Y;
            string pos;

            Console.Write("Valor de X: ");
            X = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de Y: ");
            Y = Double.Parse(Console.ReadLine(), CI);

            if (X == 0 && Y == 0)
            {
                pos = "ORIGEM";
            }
            else if (X > 0 && Y > 0)
            {
                pos = "Q1";
            }
            else if (X < 0 && Y > 0)
            {
                pos = "Q2";
            }
            else if (X < 0 && Y < 0)
            {
                pos = "Q3";
            }
            else if (X > 0 && Y < 0)
            {
                pos = "Q4";
            }
            else if (Y > 0 || Y < 0)
            {
                pos = "EIXO Y";
            }
            else
            {
                pos = "EIXO X";
            }

            Console.WriteLine(pos);



        }
    }
}
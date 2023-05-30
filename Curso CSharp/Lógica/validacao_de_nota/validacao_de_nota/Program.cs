/* 
Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a 
média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao 
intervalo [0,10]). Cada nota deve ser validada separadamente.  
*/

using System;
using System.Globalization;

namespace validacao_de_nota
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double media;

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine(), CI);

            while ((nota1 < 0) || (nota1 > 10.0)) 
            {
                Console.Write("Valor inválido! Tente novamente: ");
                nota1 = double.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine(), CI);

            while ((nota2 < 0) || (nota2 > 10.0))
            {
                Console.Write("Valor inválido! Tente novamente: ");
                nota2 = double.Parse(Console.ReadLine(), CI);
            }

            media = (nota1 + nota2) / 2;
            Console.WriteLine("MÉDIA = {0}", media.ToString("F2", CI));            

        }
        }
    }

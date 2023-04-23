/* 
Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de 
uma disciplina anual. Em seguida, mostrar a nota final que o aluno obteve (com uma casa decimal) no 
ano juntamente com um texto explicativo. Caso a nota final do aluno seja inferior a 60.00, mostrar a 
mensagem "REPROVADO", conforme exemplos.
*/

using System;
using System.Globalization;

namespace notas             
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Digite a primeira nota: ");
            double nota1 = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            double nota2 = Double.Parse(Console.ReadLine(), CI);

            double notaf = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + notaf.ToString("F1", CI));

            if (notaf <= 60.00)
            {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
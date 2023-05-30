/* Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram 
no 1º e 2º semestres. Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir 
os nomes dos alunos aprovados, considerando aprovados aqueles cuja média das notas seja maior ou 
igual a 6.0 (seis). */

using System;
using System.Globalization;

namespace aprovados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos alunos serão digitados? ");
            int N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite nome, primeira e segunda nota do {0}o aluno: ", i + 1);
                nome[i] = Console.ReadLine();
                nota1[i] = Double.Parse(Console.ReadLine(), CI);
                nota2[i] = Double.Parse(Console.ReadLine(), CI);               
            }

            double media;
            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0;i < N; i++)
            {
                media = (nota1[i] + nota2[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nome[i]);
                }
            }

        }
    }
}
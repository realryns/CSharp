/* 
Fazer um programa para ler uma duração de tempo em segundos, daí imprimir na tela esta duração no 
formato horas:minutos:segundos.  
*/

using System;
using System.Globalization;

namespace duracao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int duracao, segundos, resto, minutos, horas;

            Console.Write("Digite a duração em segundos: ");
            duracao = int.Parse(Console.ReadLine());

            horas = duracao / 3600;
            resto = duracao % 3600;

            minutos = resto / 60;
            segundos = resto % 60;


            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
using System;
using System.Net.Http.Headers;
using System.Runtime.Serialization;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int cont = 1;

            while (cont <= 10)
            {
                int num = int.Parse(Console.ReadLine());
                soma = soma + num;
                cont++;
            }

            

            Console.WriteLine("oi");
)
        }
    }
}
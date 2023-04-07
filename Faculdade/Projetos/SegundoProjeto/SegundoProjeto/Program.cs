using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
                  
            while (n >= 0)
            {
                int res = n % 2;
                if (res == 0)
                {
                    Console.WriteLine("O NÚMERO " + n + " É PAR!");
                } else
                {
                    Console.WriteLine("O NÚMERO " + n + " É IMPAR!");
                }
                Console.WriteLine("Digite um número: ");
                int n = int.Parse(Console.ReadLine());
            }
            
        }
    }
}

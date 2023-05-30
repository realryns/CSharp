using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Deseja a tabuada para qual valor? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int res = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, res);
            }

        }
    }
}
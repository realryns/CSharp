using System;

class URI
{

    static void Main(string[] args)
    {

        int a, b, c;

        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            a = (int)Math.Pow(i, 1);
            b = (int)Math.Pow(i, 2);
            c = (int)Math.Pow(i, 3);
            Console.WriteLine(a + " " + b + " " + c);
        }

    }

}
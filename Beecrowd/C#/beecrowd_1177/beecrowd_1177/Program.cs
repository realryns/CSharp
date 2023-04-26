using System;

class URI
{

    static void Main(string[] args)
    {

        int[] N = new int[1000];

        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < N.Length; i++)
        {
            N[i] = i % T;
        }

        for (int i = 0; i < N.Length; i++)
        {
            Console.WriteLine("N[{0}] = {1}", i, N[i]);
        }

    }

}
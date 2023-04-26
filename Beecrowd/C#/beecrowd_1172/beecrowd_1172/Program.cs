using System;

class URI
{

    static void Main(string[] args)
    {

        int[] X = new int[10];

        for (int i = 0; i < X.Length; i++)
        {
            X[i] = int.Parse(Console.ReadLine());

            if (X[i] <= 0)
            {
                X[i] = 1;
            }
        }

        for (int i = 0; i < X.Length; i++)
        {
            Console.WriteLine("X[" + i + "] = " + X[i]);
        }

    }

}
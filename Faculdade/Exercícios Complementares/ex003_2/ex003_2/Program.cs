using System;
class ex004_2
{
    static void Main()
    {

        int pares = 0;

        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine(pares);

    }
}
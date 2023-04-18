using System;
class ex003_2
{
    static void Main()
    {

        int impares = 0;

        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 != 0)
            {
                impares++;
            }
        }

        Console.WriteLine(impares);

    }
}
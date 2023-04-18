using System;
class HelloWorld
{
    static void Main()
    {

        int R = 0, W = 0;

        int N = int.Parse(Console.ReadLine());

        while (N > 0)
        {
            N -= 2;
            R = R + 10;
            W = N % 2;

            if (W == 1)
            {
                R = ++R - 1;
            }
            else
            {
                R = ++R + 1;
            }

        }

        Console.WriteLine(R);

    }
}

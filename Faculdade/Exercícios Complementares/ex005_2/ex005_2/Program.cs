using System;
class ex005_2
{
    static void Main()
    {

        int maior = 0;

        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > maior)
            {
                maior = num;
            }
        }

        Console.WriteLine(maior);

    }
}
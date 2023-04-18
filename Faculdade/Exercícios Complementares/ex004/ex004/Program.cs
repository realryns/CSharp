using System;
class ex004
{
    static void Main()
    {

        int cont = 1, impares = 0;

        while (cont <= 10)
        {
            int num = int.Parse(Console.ReadLine());
            cont++;
            if (num % 2 != 0)
            {
                impares++;
            }
        }

        Console.WriteLine(impares);

    }
}
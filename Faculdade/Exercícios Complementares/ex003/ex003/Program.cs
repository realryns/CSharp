using System;
class ex003
{
    static void Main()
    {

        int cont = 1, pares = 0;

        while (cont <= 10)
        {
            int num = int.Parse(Console.ReadLine());
            cont++;
            if (num % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine(pares);

    }
}
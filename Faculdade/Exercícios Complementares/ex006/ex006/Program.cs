using System;
class ex006
{
    static void Main()
    {

        int cont = 1;

        int menor = int.Parse(Console.ReadLine());

        while (cont <= 9)
        {
            int num = int.Parse(Console.ReadLine());
            cont++;
            if (num < menor)
            {
                menor = num;
            }
        }

        Console.WriteLine(menor);

    }
}
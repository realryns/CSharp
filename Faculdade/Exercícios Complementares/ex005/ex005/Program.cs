using System;
class ex005
{
    static void Main()
    {

        int cont = 1, maior = 0;

        while (cont <= 10)
        {
            int num = int.Parse(Console.ReadLine());
            cont++;
            if (num > maior)
            {
                maior = num;
            }
        }

        Console.WriteLine(maior);

    }
}
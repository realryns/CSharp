using System;
class HelloWorld
{
    static void Main()
    {

        int pares = 0;
        double soma = 0;

        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                soma = soma + num;
                pares++;
            }

        }

        double media = soma / pares;
        Console.WriteLine(media);

    }
}
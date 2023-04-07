using System;

class URI
{

    static void Main(string[] args)
    {

        int res, par = 0, impar = 0, positivo = 0, negativo = 0;

        for (int i = 0; i < 5; i++)
        {
           int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                positivo++;
            }
            else if (num < 0)
            {
                negativo++;
            }

            res = num % 2;
            if (res == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }

        }

        Console.WriteLine($"{par} valor(es) par(es)");
        Console.WriteLine($"{impar} valor(es) impar(es)");
        Console.WriteLine($"{positivo} valor(es) positivo(s)");
        Console.WriteLine($"{negativo} valor(es) negativo(s)");
    }

}
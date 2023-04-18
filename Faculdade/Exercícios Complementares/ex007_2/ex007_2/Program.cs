using System;
class ex007_2
{
    static void Main()
    {

        int cont = 0, num = 0;
        double soma = 0;

        for (int i = 0; num != 999;)
        {
            num = int.Parse(Console.ReadLine());
            cont++;
            soma = soma + num;
        }

        double media = (soma - 999) / (cont - 1);

        Console.WriteLine(media);

    }
}
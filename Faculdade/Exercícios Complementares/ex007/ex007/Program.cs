using System;
class ex007
{
    static void Main()
    {

        int cont = 0, num = 0;
        double soma = 0;

        num = int.Parse(Console.ReadLine());

        while (num != 999)
        {
            cont++;
            soma = soma + num;
            num = int.Parse(Console.ReadLine());
            
        }

        double media = soma / cont;

        Console.WriteLine(media);

    }
}
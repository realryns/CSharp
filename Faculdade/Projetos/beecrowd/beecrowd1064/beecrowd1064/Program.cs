using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        int cont = 0, i;
        double soma = 0, x, media;
       

        for (i = 0; i < 6; i++)
        {
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (x > 0)
            {
                cont++;
                soma = soma + x;
                
            }
        }

        media = soma / cont;

        Console.WriteLine(cont + " valores positivos");
        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));


    }
}
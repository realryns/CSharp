using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        CultureInfo CI = CultureInfo.InvariantCulture;

        double[,] M = new double[12, 12];
        double sum = 0, media = 0, cont = 0;

        char O = char.Parse(Console.ReadLine());

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                M[i, j] = Double.Parse(Console.ReadLine(), CI);
            }
        }

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                if (j >= 12 - i)
                {
                    sum += M[i, j];
                    cont++;
                }
            }
        }

        media = sum / cont;

        if (O == 'S')
        {
            Console.WriteLine(sum.ToString("F1", CI));
        }
        else if (O == 'M')
        {
            Console.WriteLine(media.ToString("F1", CI));
        }

    }

}
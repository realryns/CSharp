using System;

class URI
{

    static void Main(string[] args)
    {

        double[,] M = new double[12, 12];
        double sum = 0.0;
        double average = 0.0;

        int num = int.Parse(Console.ReadLine());
        char operacao = char.Parse(Console.ReadLine());

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                M[i, j] = Double.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 12; i++)
        {
            sum += M[num, i];
        }

        if (operacao == 'M')
        {
            average = sum / 12;
            Console.WriteLine(average.ToString("F1"));
        }
        else if (operacao == 'S')
        {
            Console.WriteLine(sum.ToString("F1"));
        }

    }

}
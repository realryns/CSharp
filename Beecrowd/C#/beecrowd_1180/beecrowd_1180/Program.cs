using System;
internal class Program
{
    private static void Main(string[] args)
    {
        
        int N = int.Parse(Console.ReadLine());
        int[] X = new int[N];
        int menor = 1000, pos = 0;

        string[] texto = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            X[i] = int.Parse(texto[i]);
            if (X[i] < menor)
            {
                menor = X[i];
                pos = i;
            }
        }

        Console.WriteLine("Menor valor: {0}", menor);
        Console.WriteLine("Posicao: {0}", pos);

    }
}
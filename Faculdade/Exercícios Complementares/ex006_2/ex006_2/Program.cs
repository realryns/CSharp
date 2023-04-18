using System;
class ex006_2
{
    static void Main()
    {
       
        int menor = int.Parse(Console.ReadLine());

        for (int i = 0; i < 9; i++)
        {
            int num = int.Parse(Console.ReadLine());           
            if (num < menor)
            {
                menor = num;
            }
        }

        Console.WriteLine(menor);

    }
}
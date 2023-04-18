using System;
class HelloWorld {
    static void Main() {

        int cont = 1, pares = 0;
        double soma = 0;

        while (cont <= 10)
        {
            int num = int.Parse(Console.ReadLine());
            cont++;
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
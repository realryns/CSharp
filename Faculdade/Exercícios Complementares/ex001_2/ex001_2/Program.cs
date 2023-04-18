using System;
class HelloWorld {
  static void Main() {

    double soma = 0, cont = 0;

    for (int i = 0; i < 10; i++)
    {
        int num = int.Parse(Console.ReadLine());
        soma = soma + num;
        cont++;
    }

    double media = soma / cont;
    Console.WriteLine(media);
    
  }
}
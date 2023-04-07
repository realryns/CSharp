// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

int cont = 0;
int soma = 0;
while (cont <= 10)
{
    int num = int.Parse(Console.ReadLine());
    cont++;
    soma = soma + num;
}

double media = soma / cont;
Console.WriteLine(media);

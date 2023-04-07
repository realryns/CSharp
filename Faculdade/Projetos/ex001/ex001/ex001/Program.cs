// See https://aka.ms/new-console-template for more information

double soma = 0;
double cont = 1;

while (cont <= 10)
{
    double num = int.Parse(Console.ReadLine());
    soma = soma + num;
    cont++;
}

double media = soma / (cont - 1);

Console.WriteLine(media);

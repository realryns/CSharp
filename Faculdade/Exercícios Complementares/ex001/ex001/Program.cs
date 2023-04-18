int cont = 1;
double soma = 0;

while (cont <= 10)
{
    int num = int.Parse(Console.ReadLine());
    cont++;
    soma = soma + num;
}

double media = soma / (cont - 1);
Console.WriteLine(media);
int N = int.Parse(Console.ReadLine());

int[] X = new int[N];
int menor = 0, pos = 0;

for (int i = 0; i < X.Length; i++)
{
    X[i] = Console.Read();
    if (X[i] < menor)
    {
        menor = X[i];
        pos = i;
    }
}

Console.WriteLine("Menor valor: {0} ", menor);
Console.WriteLine("Posicao: {0} ", pos);




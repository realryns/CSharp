int i = 8, A = 0, B = 0, C = 0, D = 0, E;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());

while (i != 5)
{
    if (i % 2 == 1)
    {
        A += 1;
        B += 2;
    }
    else
    {
        C += 2;
        D += 1;
    }
    --i;
}
E = A + B + C + D;
Console.WriteLine(E);
Console.ReadKey();

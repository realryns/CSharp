int i, A = 0, B = 0, C = 0, D = 0, E;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());

for (i = 5; i != 8; i++)
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
    
}
E = A + B + C + D;
Console.WriteLine(E);
Console.ReadKey();

int R;
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

if (A > 2)
{
    if (B > 5)
    {
        R = A + B;

    }
    else
    {
        R = A - B;
    }
}
else if (B < 10)
{
    R = B + 2;
}
else
{
    R = A + 1;
}

Console.WriteLine(R);

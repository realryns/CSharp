int X, Y, Z, W, S1, S2, Q1, Q2, R = 10;

X = 10; Y = 8; Z = 5; W = 3;

S1 = X / Y;

S2 = W / Z;

Q1 = S1 % X;

Q2 = S2 % Y;

if ( (X + Y) != 4)
{
    if (X > 3)
    {
        R = ++Q1;
    }
    else
    {
        R = --Q2;
    }
}
else
{
    R = Q1 + Q2;
}
Console.WriteLine(R);
Console.ReadKey();
int C;
int S = 8;


for (C = 3; C <= 6; C++)
{
    S = S + 2;
}

if ((C + S) > 20)
{
    S = S - C;
    S += 2;
}
else
{
    S = S + C;
    S *= 2;
}

Console.WriteLine(S);
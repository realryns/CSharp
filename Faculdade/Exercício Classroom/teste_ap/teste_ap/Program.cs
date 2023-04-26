int S = 8, C;

for (C = 3; C <= 6; C++)
{
    S += 2;
}

if ((C + S) > 20)
{
    S -= C;
    S += 2;
}
else
{
    S += C;
    S *= 2;
}

Console.WriteLine(S);
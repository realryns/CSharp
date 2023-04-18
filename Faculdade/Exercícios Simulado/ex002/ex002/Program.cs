int R = 0, W = 0, N1, N2;

N1 = int.Parse(Console.ReadLine());
N2 = int.Parse(Console.ReadLine());

if ( (N1 > 3) && (N2 >=10) )
{
    R = ++R + 5;
    W = R++ + 2;
    W++;
}
else
{
    if ((N1 > 3) || (N2 >= 4))
    {
        R = ++R + 10;
        R = ++R + 5;
        W = R++;
        --W;
    }
    else
    {
        R = ++R + 2;
        W = R++ + 8;
        ++W;
    }
}
Console.WriteLine(W);
Console.ReadKey();
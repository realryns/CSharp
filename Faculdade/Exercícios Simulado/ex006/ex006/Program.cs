double temperatura = Double.Parse(Console.ReadLine());

if (temperatura > 37.3)
{
    Console.WriteLine("ALTA");
}
else if (temperatura >= 35.4)
{
    Console.WriteLine("NORMAL");
} 
else
{
    Console.WriteLine("Baixa");
}
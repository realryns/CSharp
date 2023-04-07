// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite o comprimento do retângulo: ");
string str_lado = Console.ReadLine();
int lado = Int32.Parse(str_lado);

Console.WriteLine("Digite a altura do retângulo: ");

string str_altura = Console.ReadLine();
int altura = Int32.Parse(str_altura);

//Processamento

int area = altura * lado;
int perimetro = 2 * (altura + lado);

//Saída

Console.WriteLine("ÁREA = " + area + ".");
Console.WriteLine("PERÍMETRO = " + perimetro + ".");

    
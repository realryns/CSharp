using System;
using System.Globalization;

namespace aumento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario, novoSalario, aumento, porcentagem;

            Console.Write("Digite o salário da pessoa: ");
            salario = Double.Parse(Console.ReadLine(), CI);
            
            if (salario <= 1000.00)
            {
                porcentagem = 20;
                aumento = salario * porcentagem / 100;
                novoSalario = salario + aumento;
            }
            else if (salario <= 3000.00)
            {
                porcentagem = 15;
                aumento = salario * porcentagem / 100;
                novoSalario = salario + aumento;
            }
            else if (salario <= 8000.00)
            {
                porcentagem = 10;
                aumento = salario * porcentagem / 100;
                novoSalario = salario + aumento;
            }
            else
            {
                porcentagem = 5;
                aumento = salario * porcentagem / 100;
                novoSalario = salario + aumento;
            }

            Console.WriteLine("Novo salário = R$ {0}", novoSalario.ToString("F2", CI));
            Console.WriteLine("Aumento = R$ {0}", aumento.ToString("F2", CI));
            Console.WriteLine("Porcentagem = {0} %", porcentagem);

        }
    }
}
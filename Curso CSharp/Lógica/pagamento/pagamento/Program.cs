/* 
Fazer um programa para ler o nome de um(a) funcionário(a), o valor que ele(a) recebe por hora, e a 
quantidade de horas trabalhadas por ele(a). Ao final, mostrar o valor do pagamento do funcionário com 
uma mensagem explicativa, conforme exemplo. 
*/

using System;
using System.Globalization;

namespace circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome;
            double valorhora, pagamento;
            int horas;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Valor por hora: R$ ");
            valorhora = Double.Parse(Console.ReadLine(), CI);
            Console.Write("Horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());

            pagamento = valorhora * horas;

            Console.WriteLine("O pagamento para " + nome + " deve ser de R$ " + pagamento.ToString("F2", CI));          
        }
    }
}
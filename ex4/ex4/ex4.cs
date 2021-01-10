using System;
using System.Globalization;
namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o cpf do funcionário");
            int cpfunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas");
            
            double htb = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor recebido por hora");
            double horaval = double.Parse(Console.ReadLine());

            double vencimentos = horaval * htb;
            Console.WriteLine("Funcionário CPF: " + cpfunc);
            Console.WriteLine("Total de Vencimentos: "+ vencimentos.ToString("F2", CultureInfo.InvariantCulture) + " reais");

        }
    }
}

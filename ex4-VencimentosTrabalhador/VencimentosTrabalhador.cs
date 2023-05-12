using System;
using System.Globalization;
using CSharp.Helpers;

namespace ex4
{
    class VencimentosTrabalhador
    {
        static void Execute()
        {
            Console.WriteLine("Digite o cpf do funcionário");
            int cpfunc = int.Parse(Functions.ReadNonEmptyLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas");

            double htb = double.Parse(Functions.ReadNonEmptyLine());

            Console.WriteLine("Digite o valor recebido por hora");
            double horaval = double.Parse(Functions.ReadNonEmptyLine());

            double vencimentos = horaval * htb;
            Console.WriteLine("Funcionário CPF: " + cpfunc);
            Console.WriteLine(
                "Total de Vencimentos: "
                    + vencimentos.ToString("F2", CultureInfo.InvariantCulture)
                    + " reais"
            );
        }
    }
}

using System;
using CSharp.Helpers;
namespace ex2
{
    class AreaCirculo
    {
        static void Execute()
        {
            Console.WriteLine("Este programa calcula a ÁREA de um círculo a partir do raio");
            Console.WriteLine("digite o raio do seu círculo");
            double raio = double.Parse(Functions.ReadNonEmptyLine());
            double area = (raio * raio) * Math.PI;
            Console.WriteLine("a àrea do seu círculo é: " + area.ToString("F4"));

        }
    }
}

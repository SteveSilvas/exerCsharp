using System;
using CSharp.Helpers;

namespace ex3
{
    class DiferencaEntreSomas
    {
        static void Execute()
        {
            Console.WriteLine("Digite um número.");
            int a = int.Parse(Functions.ReadNonEmptyLine());
            Console.WriteLine("Digite outro número.");
            int b = int.Parse(Functions.ReadNonEmptyLine());
            Console.WriteLine("Digite outro número.");
            int c = int.Parse(Functions.ReadNonEmptyLine());
            Console.WriteLine("Digite outro número.");
            int d = int.Parse(Functions.ReadNonEmptyLine());
            int diferenca = (a * b) - (c * d);
            Console.WriteLine(
                "a Diferença entre o produto de A sobre B pelo produto de C e D é: " + diferenca
            );
        }
    }
}

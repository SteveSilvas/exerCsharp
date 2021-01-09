 using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número.");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número.");
            int d = int.Parse(Console.ReadLine());
            int diferenca = (a * b) - (c * d);
            Console.WriteLine("a Diferença entre o produto de A sobre B pelo produto de C e D é: "+ diferenca);
        }
    }
}

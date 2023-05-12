using System;
using CSharp.Helpers;
namespace ex1
{
    public static class OlaMundo
    {
        public static void Execute()
        {
            Console.WriteLine("Olá mundo do CSharp");
            System.Console.WriteLine("Digite Seu nome");
            string nome = Functions.ReadNonEmptyLine();
            Console.WriteLine("Bora codar "+ nome);
        }
    }
}

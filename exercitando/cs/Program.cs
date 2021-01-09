using System;

namespace exercitando
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados convertida e armazenada
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());
            //entrada2 
            Console.WriteLine("Digite outro número para somar");
            int numeroo = int.Parse(Console.ReadLine());
            //var de soma e saída na tela
            int soma = numero + numeroo;
            Console.WriteLine(numero + " + " +numeroo +" = "+ soma);
        }
    }
}

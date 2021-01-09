using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula a ÁREA de um círculo a partir do raio");
            Console.WriteLine("digite o raio do seu círculo");
            double raio = double.Parse(Console.ReadLine());
            double area = (raio * raio) * Math.PI;
            Console.WriteLine("a àrea do seu círculo é: " + area.ToString("F4"));

        }
    }
}

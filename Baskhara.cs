using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           Console.WriteLine("Olá, este programa calcula o valor de x em baskhara.");
           Console.WriteLine("Para isto você deve fornecer 3 informaçoes: o número quadrado - a, o número que acompanha o x (b) e o numero sem x (c)");
           
           Console.WriteLine("Digite o número que acompanh o x quadrado que chamaremos de a.");
           
           double a = double.Parse(Console.ReadLine());
           
           Console.WriteLine("Digite o número que acompanha o x que chamaremos de b.");
           
           double b = double.Parse(Console.ReadLine());
           
           Console.WriteLine("Digite o ultimo número que chamaremos de c.");
           double c = double.Parse(Console.ReadLine());
           
           
           
           Console.WriteLine(a + "a, "+b + "b, "+c+ "c.");
           
           double delta = b*b-4*a*c;
           if (delta<0){
           	  MessageBox.Show("NÃO EXISTEM VALORES DE X PARA DELTA NEGATIVO.");
           }else{
           Console.WriteLine("O delta é : "+ delta);
           
           double x1 = (-b +(Math.Sqrt(delta))/(2*a));
           double x2 = (-b -(Math.Sqrt(delta))/(2*a));
           
           Console.WriteLine("O valor de x1 é: "+ x1 +" E o valor de x2 é: "+ x2);
           MessageBox.Show("O delta é: "+delta+ "\r\n valor de x1 é: "+x1+"\r\n valor de x2 é: "+x2);
           }
        }
    }
}
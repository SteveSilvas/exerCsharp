using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios.Functions
{
    public class IMC
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Imc { get; set; }
        public string? Classificacao { get; set; }

        public void buildIMC()
        {
            Imc = Peso / Math.Pow(Altura, 2);
            classificacaoImc();
        }

        public void classificacaoImc()
        {
            if (Imc < 18.5)
            {
                Classificacao = "abaixo do peso ideal";
            }
            else if (Imc > 18.5 && Imc <= 24.9)
            {
                Classificacao = "peso normal";
            }
            else if (Imc >= 25 && Imc <= 29.9)
            {
                Classificacao = "sobrepeso, acima do peso ideal";
            }
            else
            {
                Classificacao = "obesidade";
            }
        }
    }
}

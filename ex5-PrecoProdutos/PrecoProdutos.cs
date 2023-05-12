using System;
using System.Globalization;
using CSharp.Helpers;

namespace ex5
{
    class PrecoProdutos
    {
        static void Execute()
        {
            int cod1,
                cod2,
                qte1,
                qte2;
                
            double preco1,
                preco2,
                total;

            string[] valores = Functions.ReadNonEmptyLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);

            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Functions.ReadNonEmptyLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine(
                "VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture)
            );
        }
    }
}

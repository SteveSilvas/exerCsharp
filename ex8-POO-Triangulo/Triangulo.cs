using System;

namespace CSharp.Triangulo
{
    class Triangulo
    {
        public double A = 0;
        public double B = 0;
        public double C = 0;

        public double Area()
        {
            if (A > 0 && B > 0 && C > 0)
            {
                return (A * B * C) / 2;
            }
            else
            {
                return 0.0;
            }
        }
    }
}

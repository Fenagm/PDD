using System;
using System.Collections.Generic;
using System.Text;


namespace _2020_09_08
{
    class cientifica : Calculadora
    {
        public double Potencia(double valor, double exp)
        {
            return Math.Pow(valor, exp);
        }
    }
}

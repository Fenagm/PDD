using System;
using System.Collections.Generic;
using System.Text;

namespace _2020_09_08
{
    /*
     * public
     * private
     * protected
     * internal
     * internal protected (mismo proyecto o herede clase)
     * private protected (mismo proyecto y herede clase)
     */
    public class Calculadora
    {
        private int numero1;
        public int Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value;
            }
        }

        public int Numero2 { get; set; }

        public Calculadora(int numero1, int numero2) {
            Numero1 = numero1;
            Numero2 = numero2;
        }
        public Calculadora()
        {
          
        }

        public int Metodo()
        {
            if (Numero2 == Numero1)
            {
                return 0;
            }
            return 1;
        }

        public int Sumar( int valor, int valor2)
        {
            return valor+valor2;
        }

        public int restar(int valor, int valor2)
        {
            return valor - valor2;
        }
        public int multiplicar(int valor, int valor2)
        {
            return valor * valor2;

        }

        public int dividir(int valor, int valor2)
        {
            if (valor2 != 0)
            {
                return valor / valor2;
            }
            else { return 0; }
        }


        private class Operacion
        { }

    }
}

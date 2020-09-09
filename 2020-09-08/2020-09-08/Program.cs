using ClassLibrary1;
using System;

namespace _2020_09_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora(10,20);
            Calculadora calculadora2;
            
            calculadora2 = new Calculadora();

            calculadora.Numero1 = 10;

            Console.WriteLine(calculadora.Numero1);
            calculadora.Numero2 = 20;

            Console.WriteLine(calculadora.Numero2);
            Console.WriteLine(calculadora.Numero1 + calculadora.Numero2);

            Console.WriteLine(calculadora.Sumar(2, 4));
            Console.WriteLine(calculadora.restar(2, 4));
            Console.WriteLine(calculadora.dividir(2, 4));
            Console.WriteLine(calculadora.multiplicar(2, 4));
            cientifica cientifica = new cientifica();
            Console.WriteLine(cientifica.Potencia(2, 6));



        }
    }
}

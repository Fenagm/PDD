using System;

namespace clase1_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("ingrese su edad:");
            //string valor = Console.ReadLine();
            //int edad = int.Parse(valor);
            //string mensaje;

            //if (edad < 16)
            //{
            //    mensaje = "No habilitado a votar";

            //}
            //else if ((16 < edad && edad < 21) || edad>68)
            //{

            //    mensaje = "Votar es optativo";
            //}
            //else if (edad > 21 && edad < 68)
            //{

            //    mensaje = "Votar es obligatorio";
            //}
            //else 
            //{
            //    mensaje = "error en la edad ingresada";
            //}
            //Console.WriteLine("su edad es: "+ edad);
            //Console.WriteLine("su condicion es : "+ mensaje);
            //Console.Write($"tu edad es {edad} y tu condicion es {mensaje}");
            //Console.WriteLine(string.Format("tu edad es {0} y tu condicion es {1}", edad, mensaje));


            
                int suma = 0;
            for (int i=0; i<10; i++)
            {
                if (suma < 51)
                {
                    string val;
                    Console.WriteLine("Ingrese un numero: ");
                    val = Console.ReadLine();
                    int num = int.Parse(val);
                    suma = suma + num;
                    Console.WriteLine(suma);
                }
                else
                {
                    Console.WriteLine("la suma supera 50");
                    break;
                }
            }

        }
    }
}

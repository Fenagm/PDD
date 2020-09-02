using System;

namespace clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int winner = random.Next(10)+1;
            int cont = 0;
            int apuesta;

            
            do
            {

                apuesta = Preguntar("ingrese un numero de 1 a 10:", out apuesta);
                cont++;
               

                if (winner == apuesta)
                    {
                        Console.WriteLine(Ganaste());
                    }
                    else
                    {
                        Console.WriteLine("Estuvo cerca, vuelve a intentar!");
                    if (cont == 3) {
                        Console.WriteLine(Perdiste(winner));
                    }
                    }
                
              
                } while (winner != apuesta && cont <= 2);

            

            int numero;
            numero = Fecha("ingrese su año de nacimiento y compruebe si es bisiesto: ");
            bool checker;
            CalcularAñoBisiesto(numero, out checker);
            if (checker)
            {
                Console.WriteLine("el año es bisiesto");
            }
            else
            {
                Console.WriteLine("el año no es bisiesto");
            }

        }
        static int Fecha(string mensaje)
        {
            Console.WriteLine(mensaje);
            string val = Console.ReadLine();
            return int.Parse(val);

        }

        static Boolean CalcularAñoBisiesto(int anio, out bool checker)
        {
            if ((anio % 4 == 0) && ((anio % 100 != 0) || (anio % 400 == 0)))
                checker = true;
            else
                checker = false;

            return checker;
        }
        
        static String Ganaste()
        {
            return "ganaste!";
        }

        static string Perdiste( int valor)
        {
            return "Perdiste!, el numero correcto era: " + valor;
        }

        static int Preguntar(string mensaje, out int apuesta)
        {
            Console.WriteLine(mensaje);
            string valor= Console.ReadLine();

            apuesta=  int.Parse(valor);
            return apuesta;


        }

    }


 
}

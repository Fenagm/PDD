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

                Console.WriteLine("Tenes tres intentos, Intento N°:"+(cont+1));
                Console.WriteLine("adivine el numero entre 1 y 10");
                
                Console.WriteLine(winner);
                apuesta = int.Parse(Console.ReadLine());
                cont++;

               
                    if (winner == apuesta)
                    {
                        Console.WriteLine("Ganaste!");
                    }
                    else
                    {
                        Console.WriteLine("Estuvo cerca, vuelve a intentar!");
                    if (cont == 3) {
                        Console.WriteLine("Perdiste!");
                    }
                    }
                
              
                } while (winner != apuesta && cont <= 2);

          

        }
    }
}

using System;

namespace _2020_08_25
{
    class Program
    {
        static void Main(string[] args)
        {

            int winner = 7;
            int apuesta = 0;

            while (winner!=apuesta)
            {
                Console.WriteLine("adivine el numero entre 1 y 10");
                apuesta = int.Parse(Console.ReadLine());
                
             
            }

            Console.WriteLine("Ganaste!");

        }
    }
}

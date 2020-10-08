using System;
using System.Linq;
namespace _2020_09_29
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listaDeNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPar = listaDeNumeros.Where(n => n % 2 == 0).OrderByDescending(n => n);
            foreach (var n in numerosPar)
            {
                Console.WriteLine(n);
            }
        }


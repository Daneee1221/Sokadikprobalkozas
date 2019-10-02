using System;
using System.Collections.Generic;
using System.Linq;

namespace Feladat1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Console.WriteLine("Kérem adja meg a lista méretét: ");
            int meret = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < meret; i++)
            {
                Console.WriteLine("Adjon meg egy számot: ");
                lista.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("A legnagyobb szám: " + lista.Max());
            Console.ReadKey();
        }
    }
}
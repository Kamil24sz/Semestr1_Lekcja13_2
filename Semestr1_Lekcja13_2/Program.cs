using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metody cz2

            for (int i = 1; i < 10; i++)
            {
                Wypisywanie();
            }

            Console.ReadLine();
        }
        
        static float ObliczObjetoscKuli(float r)
        {
            // objetosc = 4/3 * PI * r^3

            return (float)(4 / 3 * Math.PI * Math.Pow(r, 3));
        } 

        static void Wypisywanie()
        {
            ObliczObjetoscKuli(2);
        }
    }
}

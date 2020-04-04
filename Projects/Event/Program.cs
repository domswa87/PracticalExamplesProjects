using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        public delegate void DelegatDS(string s);
        public static event DelegatDS EventDS;

        static void Main(string[] args)
        {
            EventDS += Metoda1;
            EventDS += Metoda2;
            EventDS += Metoda3;
            EventDS.Invoke("Hello");

            Console.ReadKey();
        }

        static void Metoda1(string s)
        {
            Console.WriteLine("Metoda1 : " + s);
        }

        static void Metoda2(string s)
        {
            Console.WriteLine("Metoda2 : " + s);
        }

        static void Metoda3(string s)
        {
            Console.WriteLine("Metoda3 : " + s);
        }
    }
}

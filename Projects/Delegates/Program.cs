using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void DelegatDS(string s);

        static void Main(string[] args)
        {
            DelegatDS delegatDS1 = new DelegatDS(Metoda1);
            DelegatDS delegatDS2 = new DelegatDS(Metoda2);
            DelegatDS delegatDS3 = new DelegatDS(Metoda3);

            delegatDS1.Invoke("hello");
            delegatDS2.Invoke("hello");
            delegatDS3.Invoke("hello");

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

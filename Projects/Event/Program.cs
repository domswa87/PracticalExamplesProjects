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
            EventDS += Person1;
            EventDS += Person2;
            EventDS += Person3;
            EventDS.Invoke("Hello");

            Console.ReadKey();
        }

        static void Person1(string s)
        {
            Console.WriteLine("Person1 : " + s);
        }

        static void Person2(string s)
        {
            Console.WriteLine("Person2 : " + s);
        }

        static void Person3(string s)
        {
            Console.WriteLine("Person3 : " + s);
        }
    }
}

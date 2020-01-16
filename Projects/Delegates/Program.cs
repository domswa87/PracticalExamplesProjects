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
            DelegatDS delegatDS1 = new DelegatDS(Person1);
            DelegatDS delegatDS2 = new DelegatDS(Person2);
            DelegatDS delegatDS3 = new DelegatDS(Person3);

            delegatDS1.Invoke("hello");
            delegatDS2.Invoke("hello");
            delegatDS3.Invoke("hello");

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

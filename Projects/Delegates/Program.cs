using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates.Program;

namespace Delegates
{
    public class Program
    {
        // 1 Tworze Delegata
        public delegate void DelegatDS(string s);

        static void Main(string[] args)
        {
            // 2 Tworze obiekt Delegata i przypisuje metode jaka ma wywolac
            DelegatDS delegatDS1 = new DelegatDS(Metoda1);

            // 3 wysylam delegata
            OtherClass o = new OtherClass(delegatDS1);
            o.Start();


            Console.ReadKey();
        }

        static void Metoda1(string s)
        {
            Console.WriteLine("Metoda1 : " + s);
        }

    }

    public class OtherClass
    {
        public DelegatDS delegat { get; set; }
        public OtherClass(DelegatDS delegatDS1)
        {
            delegat = delegatDS1;
        }
        public void Start()
        {
            delegat.Invoke("info od delegata wyslanego do innej klasy");
        }

    }


}

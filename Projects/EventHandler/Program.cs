using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerNameSpace
{
    public class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass obj = new NotStaticClass();
            obj.MainMetodaDS();
            Console.ReadKey();
        }
    }

    public class NotStaticClass
    {
        public event EventHandler EventHandlerDS;

        public void MainMetodaDS()
        {
            ObjectSenderClass obj = new ObjectSenderClass() { text = "hello EventHandler" };
            EventArgs eventArgs = new EventArgs();

            // Add 1,2,3 
            EventHandlerDS += Metoda1;
            EventHandlerDS += Metoda2;
            EventHandlerDS += Metoda3;

            // Substract 2
            EventHandlerDS -= Metoda2;

            EventHandlerDS.Invoke(obj, eventArgs);
        }

        private void Metoda1(object sender, EventArgs e)
        {
            ObjectSenderClass obj = (ObjectSenderClass)sender;     Console.WriteLine("Metoda1 : " + obj.text);
        }
        private void Metoda2(object sender, EventArgs e)
        {
            ObjectSenderClass obj = (ObjectSenderClass)sender;      Console.WriteLine("Metoda2 : " + obj.text);
        }
        private void Metoda3(object sender, EventArgs e)
        {
            ObjectSenderClass obj = (ObjectSenderClass)sender;       Console.WriteLine("Metoda3 : " + obj.text);
        }
    }
    
    public class ObjectSenderClass
    {
        public string text { get; set; }
    }
}

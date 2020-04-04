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
            EventHandlerDS += Person1;
            EventHandlerDS += Person2;
            EventHandlerDS += Person3;

            // Substract 2
            EventHandlerDS -= Person2;

            EventHandlerDS.Invoke(obj, eventArgs);
        }

        private void Person3(object sender, EventArgs e)
        {
            ObjectSenderClass obj = (ObjectSenderClass)sender;
            Console.WriteLine("Person3 : " + obj.text);
        }

        private void Person2(object sender, EventArgs e)
        {
            ObjectSenderClass obj = (ObjectSenderClass)sender;
            Console.WriteLine("Person2 : " + obj.text);
        }

        private void Person1(object sender, EventArgs e)
        {
            ObjectSenderClass obj = (ObjectSenderClass)sender;
            Console.WriteLine("Person1 : " + obj.text);
        }
    }

    public class ObjectSenderClass
    {
        public string text { get; set; }
    }
}

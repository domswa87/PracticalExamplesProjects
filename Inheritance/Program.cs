using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // HIDING
            Child Child = new Child();
            Console.WriteLine(Child.speak());                               // 1.  => "VirtualBase"       NO HIDDING !!!

            ChildHide ChildHide = new ChildHide();                         
            Console.WriteLine(ChildHide.speak());                           // 2.  => "ChildShadowing"    HIDDING !!!

            ChildOverride ChildOverride = new ChildOverride();
            Console.WriteLine(ChildOverride.speak());                       // 3.  => "ChildOverride"     HIDDING !!!

            // OVERRIDING  
            VirtualBase ChildBase = new Child();                    
            Console.WriteLine(Child.speak());                                // 1.  => "VirtualBase"     NO OVERRIDING !!!

            VirtualBase ChildHideBase = new ChildHide();
            Console.WriteLine(ChildHideBase.speak());                        // 2.  => "VirtualBase"     NO OVERRIDING !!!

            VirtualBase ChildOverrideBase = new ChildOverride();
            Console.WriteLine(ChildOverrideBase.speak());                    // 3. => "ChildOverride"    OVERRIDING !!!

            Console.ReadKey();
        }
    }

    public class VirtualBase {public virtual string speak() => "VirtualBase"; }
    public class Child : VirtualBase { }                                                            // NIE PRZYKRYWA NIE NADPISUJE
    public class ChildHide : VirtualBase  {public new string speak() => "ChildShadowing"; }         // TYLKO PRZYKRYWA 
    public class ChildOverride : VirtualBase { public override string speak() => "ChildOverride"; } // PRZYKRYWA I NADPISUJE

}

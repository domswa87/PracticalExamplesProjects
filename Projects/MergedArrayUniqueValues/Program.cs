using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ds = System.Text;

namespace MergedArrayUniqueValues
{
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            return names1.Union(names2).ToArray();
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
            Console.ReadKey();
        }
    }

}

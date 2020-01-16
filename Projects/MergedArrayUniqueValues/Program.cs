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
            var mergedArray = names1.Concat(names2);
            var mergedArrayDistinc = mergedArray.Distinct().ToList();
            string[] FinalArray = new string[mergedArrayDistinc.ToList().Count];

            for (int i = 0; i < mergedArrayDistinc.ToList().Count; i++)
            {
                FinalArray[i] = mergedArrayDistinc.ElementAt(i);
            }

            return FinalArray;
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
            Console.ReadKey();
            //ds
        }
    }

}

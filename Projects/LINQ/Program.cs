using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] Array1 = { 1, 1, 2, 3, 4, 5, 6 };
            int[] Array2 = { 4, 5, 6, 7, 8, 9, 9 };

            LinqIntersect(Array1, Array2); // 4,5,6  - shared part
            LinqUnion(Array1, Array2);     // 1,2,3,4,5,6,7,8,9 - without duplicates from two collections
            LinqDistinct(Array1, Array2);  // without duplicates from one collection
            LinqOrder();

            Console.ReadKey();
        }


        public static void LinqIntersect(int[] array1, int[] array2)
        {
            IEnumerable<int> result = array1.Intersect(array2);
        }

        public static void LinqUnion(int[] array1, int[] array2)
        {
            IEnumerable<int> result = array1.Union(array2);
        }

        public static void LinqDistinct(int[] array1, int[] array2)
        {
            IEnumerable<int> result1 = array1.Distinct();
            IEnumerable<int> result2 = array2.Distinct();
        }

        public static void LinqOrder()
        {
            string[] ArrayTable = { "ala", "ma", "kota","a","aa","aaa","aaaa","bb","bbb","bbbb" };

            var result1 = ArrayTable.OrderBy(x=>x.Length).ToArray();  // lenght of String
            var result2 = ArrayTable.OrderBy(x => x).ToArray();       // alfabetically
            var result3 = ArrayTable.Select(x => x).Where(x => x.Length > 3).OrderBy(x => x).ToArray();

            string[] ArrayTable2 = { "ala", "ma", "kota"};
            var result4 = string.Join(null, ArrayTable2);  // alamakota

        }
    }
}

using System;
using System.Collections.Generic;

namespace TestDS
{
    class Program
    {
        static Random rand = new Random();
        static int[] numbers = { 1, 2, 3, 4, 5, 6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
        static void Main(string[] args)
        {
            foreach (var item in GetNumbers(10))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static IEnumerable<int> GetNumbers(int count)
        {
            Console.WriteLine("start");
                yield return 9;
            Console.WriteLine("end!!");
        }
    }
}

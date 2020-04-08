using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeld
{
    class Program
    {
        static int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static void Main()
        {
            YieldDS ds = new YieldDS(numbers);
            IEnumerator<int> enumerator = ds.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int i = enumerator.Current;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }


        static IEnumerable<int> GetEvenNumbers(int[] array)
        {
            return new YieldDS(array);
        }
    }

    public class YieldDS : IEnumerable<int>, IEnumerator<int>
    {
        int i;
        int state;
        int current;
        int[] numbers;
        public YieldDS(int[] array)
        {
            numbers = array;
        }
        public bool MoveNext()
        {
            switch (state)
            {
                case 0:
                    i = 0;
                    goto case 1;
                case 1:
                    state = 1;
                    if (!(i < numbers.Length))
                        return false;
                    else
                        goto case 3;
                case 2:
                    state = 2;
                    if (i % 2 == 0)
                    {
                        current = i;
                        state = 3;
                        return true;
                    }
                    else 
                        goto case 3;
                case 3:
                    i++;
                    goto case 1;
            }
            return false;
        }

        public int Current
        {
            get
            {
                return numbers[current];
            }
        }
      
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {
           
        }
        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }
        public void Reset()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

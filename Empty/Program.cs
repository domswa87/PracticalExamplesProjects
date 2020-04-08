using System;
using System.Collections;
using System.Collections.Generic;

namespace Empty
{
    class Program
    {
        // ZASTOSOWANIE
        static void Main()
        {
            ListDS<int> listDS = new ListDS<int>();  // size 2
            listDS.Add(1);
            listDS.Add(2);
            listDS.Add(3); // size 4
            listDS.Add(4);
            listDS.Add(5); // size 8
            listDS.Add(6);

            
            foreach (var item in listDS)
            {
                Console.WriteLine(item);
            }

            // ODPOWIEDNIK FOR EACH
            IEnumerator<int> enumerator = listDS.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
                    
            }
            finally
            {
                enumerator.Dispose();
            } 
            Console.ReadKey();
        }
    }

    // WŁASNA LISTA
    public class ListDS<T>
    {
        public T[] items = new T[10];
        public int count = 0;
        public void Add(T item)
        {
            if (count== items.Length)
                Array.Resize(ref items, items.Length * 2);

            items[count] = item;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new EnumeratorDS<T>(this);
        }
    }

    // WŁASNY ENUMERATOR
    public class EnumeratorDS<T> : IEnumerator<T>
    {
        ListDS<T> List;
        int index = -1;
        public T Current 
        {
            get
            {
                if (index < 0 || index > List.count)
                    throw new IndexOutOfRangeException();
                else
                    return List.items[index];
            }
        }
        public EnumeratorDS(ListDS<T> list)
        {
            this.List = list;
        }
        public bool MoveNext()
        {
            index++;
            return index < List.count;
        }
        // PONIZSZE METODY NIE BIORĄ UDZIAŁU
        object IEnumerator.Current => Current;  // Not used - nawet jezeli to wywoła się metoda Current powyzej
        public void Dispose(){}
        public void Reset(){ throw new NotSupportedException(); }   // Not used
    }
}

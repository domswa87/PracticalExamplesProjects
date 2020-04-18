using System;

namespace DelegatLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Start s = new Start();
            s.StartMethod();
        }
    }


    public class Start
    {
        public void StartMethod()
        {
            // GENERYCZNE DELEGATY

            // ACTION - ZWRACA VOID, WSKAZUJEMY CO PRZYJMUJE
            Action<int, int, int> action = (n1, n2, n3) => Console.WriteLine(n1 + n2); ;

            // PREDICATE - ZWRACA BOOL, WSKAZUJEMY CO PRZYJMUJE - ZAMIAST TEGO MOŻNA UŻYWAĆ FUNC
            Predicate<int> predicate = int1 => false;
            Predicate<string> predicate1 = str1 => true;
            Func<string, bool> funcPredicate = str1 => true;

            // FUNC - WSKAZUJEMY CO PRZYJMUJE I CO ZWRACA
            // MOŻLIWOŚCI PRZYPISANIA METODY
            Func<int, string> func1 = FuncMethod;                                                           // METODA
            Func<int, string> func2 = n1 => (n1 * 10).ToString();              //LAMBDA
            Func<int, string> func3 = delegate (int n1) { return (n1 * 10).ToString(); };       //METODA ANONIMOWA

            //METODA ANONIMOWA ROZBITA
            Func<int, string> func4 =
             // ZAMIAST NAZWY METODY JEST SLOWO DELEGATE
             // WIDAC ZE PRZYJMUJE INT
             // NIE TRZEBA PISAC CO BEDZIE ZWRACALA BO WIDAC ZE STRING
             delegate (int n1)
             {
                 string str = (n1 * 10).ToString();
                 return str;
             };




            // WYWOŁANIE
            // PRZEKAZUJE FUNC
            string sFunc1 = SecondMethod(func1);
            string sFunc2 = SecondMethod(func2);
            string sFunc3 = SecondMethod(func3);
            string sFunc4 = SecondMethod(func4);
            // LUB PISZEMY FUNC WEWNATRZ METODY
            string s1 = SecondMethod(FuncMethod);
            string s2 = SecondMethod(n1 => (n1 * 10).ToString());
            string s3 = SecondMethod(delegate (int n1) { return (n1 * 10).ToString(); });
            string s33 = SecondMethod(

            // METODA ANONIMOWA
            delegate (int n1)  // zamiast nazwy metody jest slowo delegat
            {
                return (n1 * 10).ToString();

            });
        }

        public string SecondMethod(Func<int, string> func)
        {
            int n1 = 1;
            return func.Invoke(n1);
        }

        public string FuncMethod(int n1)
        {
            string s = (n1 * 10).ToString();
            return s;
        }


    }
}

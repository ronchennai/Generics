using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Check<int> c = new Check<int>();
            var chk = c.Compare(2, 4);
            Console.WriteLine($"Comparison between 2 & 4 is: {chk}");

            Check<string> c2 = new Check<string>();
            var chk2 = c2.Compare("Ron", "Ron");
            Console.WriteLine($"Comparison between Ron & Ron is: {chk2}");
           
            NonGenericClass ngc = new NonGenericClass();
            var max =  ngc.Max(3, 10);
            Console.WriteLine($"Maximum between 3 & 10 is: {max}");
            Console.ReadLine();
        }
    }

    class Check<T>
    {
        public bool Compare(T x, T y)
        {
            return x.Equals(y) ? true : false;
        }
    }
    class NonGenericClass
    {
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}

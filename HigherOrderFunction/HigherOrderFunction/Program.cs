using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrderFunction
{
    class Program
    {
        static Func<int, int> Function1 = x => x + 2;
        static Func<int, int> Function2 = x => x + 3;
        static Func<Func<int, int>, Func<int, int>, Func<int, int>> Compose = (func1, func2) => x => func1(func2(x));
        static void Main(string[] args)
        {
            var Test = Compose(Function1, Function2);
            Console.WriteLine(Test(1));
            Console.ReadKey();
        }
    }
}

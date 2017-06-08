using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSheep
{
    class Program
    {
        static void Main(string[] args)
        {
            var sheeps = new bool[] 
            {
                true, true, true, false,
                true, true, true, true,
                true, false, true, false,
                true, false, false, true,
                true, true, true, true,
                false, false, true, true
            };
            Console.WriteLine(CountSheeps.Count(sheeps));
            Console.ReadKey();
        }
    }
}

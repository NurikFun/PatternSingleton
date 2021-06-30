using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    class Program
    {
        static void Main(string[] args)
        {

            var value = LazySingleton.Instance;

            value.Calculate(5, 6);


            Console.ReadKey();
        }
    }
}

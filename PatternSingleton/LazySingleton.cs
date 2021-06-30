using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = 
            new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {

        }

        public static LazySingleton Instance { get { return _instance.Value; } }


        public void Calculate(int a, int b)
        {
            Console.WriteLine(a + b);
        }


    }
}

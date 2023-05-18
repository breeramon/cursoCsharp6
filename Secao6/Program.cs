using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Secao6
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Soma(2, 3);
            int s2 = Calculator.Soma(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            int s3 = Calculator.Soma(20, 30, 40);
            int s4 = Calculator.Soma(20, 30, 45, 55);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.ReadKey();
        }
    }
}

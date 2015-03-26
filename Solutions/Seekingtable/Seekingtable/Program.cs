using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seekingtable
{
    class Program
    {
        // for x = 1,4,7.. f(x) = 3
        //     x = 2,5,8.. f(x) = 2
        //     x = 3,6,9.. f(x) = 1
        // construct method f(x)

        static int[] table = { 3, 2, 1 };
        static void Main(string[] args)
        {

            for (int i = 0; i < 9; i++)
                f(i);
        }

        static void f(int x)
        {
            int remaind = x % 3;
            //Console.WriteLine("x is " + x + " remaind is " + remaind);

            Console.WriteLine("f(" + x + ") is " + table[remaind]);
        }
    }
}

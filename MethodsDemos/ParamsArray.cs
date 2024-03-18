using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemos
{
    internal class ParamsArray
    {
        static void Main()
        {
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 45, 345, 345, 34, 53, 45, 34, 53, 45, 345, 345));
        }

        static int Add (params int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum; 
        }
        //static int Add(int x, int y)
        //{

        //}
        //static int Add(int x, int y, int z)
        //{

        //}
    }
}

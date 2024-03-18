using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemos
{
    internal class MethodOverloading
    {
        static void Main()
        {
            Console.WriteLine(Add(1, 2, 3));
            Console.WriteLine(Add("a", "b"));
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        //static void Add(int x, int y)
        //{
        //    return x + y;
        //}
        static int Add(int x,  int y , int z)
        {
            return x+y+z;
        }
        static string Add(string x, string y)
        {
            return string.Concat(x, " ", y);
        }

        static int Add(int x, float y)
        {
            return x + (int)y;
        }
    }

}

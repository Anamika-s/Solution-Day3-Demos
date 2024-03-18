using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemos
{
    internal class DefaultParameter
    {   // seq from right to left
        //static float SI(int principal, int rate = 5, int time)


        static float SI (int principal, int rate=5 , int time=10)
        {
            return (principal * rate * time) / 100;
        }
        static void Main()
        {
            Console.WriteLine(SI(12000, 3, 9));
            Console.WriteLine(SI(12000, 3));
            Console.WriteLine(SI(21000));
            Console.WriteLine(SI(21000, 2,3));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemos
{
    internal class OutputParameters
    {
        static void Main()
        {

            int x = 10, y = 10;
            int sum , difference , product, rem;
            Operations(x, y, out sum, out  difference , out product, out rem);
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Difference is "+ difference);
            Console.WriteLine("Product is  " + product);
            Console.WriteLine("Remainder i s" + rem);
        }
        // How many values can a function return? ONly ONE
        // If you want a function shud return more than 1 valuw, we can fo with output parameters
        static void Operations(int x, int y, out int sum , out int difference,
            out int prodcut, out int remainder)
        {
            sum = x + y;
            difference = x - y;
            prodcut = x*y;
            remainder = x%y;
        }

    }
}

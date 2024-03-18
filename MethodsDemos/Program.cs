namespace MethodsDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(10, 20);
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine(Add3("a", "b", "c"));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Add2(int x, int y, int z) {
            return x + y + z;
        }

        static string Add3(string x, string y, string z)
        {
            return string.Concat(x, y, z);
        }
        static int Add4(int x, float f)
        {
            return x + (int)f;
        }

    }
}
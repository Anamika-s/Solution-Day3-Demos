namespace ArrayDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Conversion > Changing type of variable to other type
            // conversion can happen in 2 ways
            // implici & explicit
            // implicit > which happens by def
            // expilicit > that we have to do
            int x;
            Console.WriteLine("Enter No of x");
            x = Convert.ToByte(Console.ReadLine()); // explicit conversion
            float f = 90.5f;
            x = (int)f;

            x = 20;
            f = x;

            decimal d = 10;
            f = (float) d;

            d = (decimal) f;

            int data = 90;
            byte data1 = 100;
            data = data1;
            data1 = (byte) data;

            string num1 = "10";
            data1 = Convert.ToByte(num1);






            x = Convert.ToInt16(f);




            int[] num = new int[10];
            Console.WriteLine("Enter the numbers");

            for(int i = 0;i<10;i++)
                num[i] = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Elements are ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = 10 + i;
                Console.WriteLine(num[i]);
            }
            // foreach
            // syntax for foreach loop
            // foreach(type_of_var range_var in array/collection
            // print range_var

            foreach (int temp in num)
                //temp = 10 + 9;
                Console.WriteLine(temp);

            Console.WriteLine("Reverse ");
            for(int i = num.Length-1;i>=0;i--)
                Console.WriteLine(num[i]);

            Array.Sort(num);
            Console.WriteLine("Elements in Sorted order are ");
            for (int i = 0; i < num.Length; i++)
                Console.WriteLine(num[i]);

           Array.Reverse(num);


        }
    }
}
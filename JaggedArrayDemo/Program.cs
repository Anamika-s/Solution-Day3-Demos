namespace JaggedArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] marks = new int[10][];
            marks[0] = new int[3];
            marks[1] = new int[2];
            Console.WriteLine("Enter Marks of 1st student");
            marks[0][0] = Byte.Parse(Console.ReadLine());
            marks[0][1] = Byte.Parse(Console.ReadLine());
            marks[0][2] = Byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of 2nd student");
            marks[1][0] = Byte.Parse(Console.ReadLine());
            marks[1][1] = Byte.Parse(Console.ReadLine());
          

        }
    }
}
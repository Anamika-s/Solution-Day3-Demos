namespace Search_Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 20, 12, 13, 19, 21, 22, 23, 90, 27, 100 };
            Console.WriteLine("Enter ELement to search");
            int numToSearch= Int16.Parse(Console.ReadLine());
            bool flag = LinearSearch(num, numToSearch);
            if (flag == true)
                Console.WriteLine("Element found");
            else Console.WriteLine("ELement Not Found");
        }

        static bool LinearSearch(int[] num, int numToSearch)
        {
            bool flag = false;
            foreach(int temp in num)
            {
                if(temp == numToSearch)
                { 
                  flag = true; 
                  break;
                }
            }
            return flag;
        }
    }
}
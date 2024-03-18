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

            int index = PerformLinearSearch(num, numToSearch);
            if (index == -1) Console.WriteLine("ELement Not Found");
            else Console.WriteLine($"Element found at {index} position");
             


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



        static int PerformLinearSearch(int[] num, int numToSearch)
        {
            int index=-1;
            for(int i = 0;i<num.Length; i++)
            {
                if (num[i] == numToSearch)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
using System.Collections.Generic;


namespace GenericCollectionDemo
{
    internal class Program
    {
         static int x = 100;
        static void Change()
        {
            x = 100;
        }
        static void Main(string[] args)
        {
            //Here x is local variable
              x = 10;

              // ArrayList is replaced with List
              List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("ajay");
            queue.Enqueue("deepak");

            Stack<float>     st = new Stack<float>();
            st.Push(1.0f);
            st  .Push(1.0f);

            // HashTable is replace with DIctionary
            Dictionary<int, int>  Marks= new Dictionary<int, int>();
            Marks[10] = 90;
            Marks[11] = 98;

        }
    }
}
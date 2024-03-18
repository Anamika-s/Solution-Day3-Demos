using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dynamic, we have not given any size
            // int[] num = new int[10];
           ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add("ajay");
            list.Add(90.8f);
            //for(int i = 0;i<list.Count;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            foreach (int temp in list)
                Console.WriteLine(temp);
            list.Insert(1, 100);
            Console.WriteLine("After inserting 100 at post 1");
            foreach (int temp in list)
                Console.WriteLine(temp);

            list.Remove(1);
            Console.WriteLine("After Removing 1");
            foreach (int temp in list)
                Console.WriteLine(temp);
            list.RemoveAt(0);
            Console.WriteLine("After Removing element at post 0");
            foreach (int temp in list)
                Console.WriteLine(temp);

            // ArrayList is one class 
            // It allows to perform insert delete anywhere
            // when you want to acheive FIFO
            // go with queue

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(90.8f);
            Console.WriteLine("Elements of queue");
            foreach (int temp in queue) Console.WriteLine(temp);

            queue.Dequeue();
            Console.WriteLine("Elements of queue after deletion");
            foreach (int temp in queue) Console.WriteLine(temp);


            // Want to follow LIFO
            Stack stack= new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("Elements of stack");
            foreach (int temp in stack) Console.WriteLine(temp);
            stack.Pop();
            Console.WriteLine("Elements of stack after deletion");
            foreach (int temp in stack) Console.WriteLine(temp);

            // For searching elemenst random;y /dynamicaly
            // use a structure that uses key value pair
            Hashtable ht = new Hashtable();
            // ht[key] = value;
            ht[1] = 90;
            ht[2] = 89;
            ht[3] = 56;

            Console.WriteLine(ht[3]);
            for(int i = 0;i<ht.Keys.Count;i++)
                Console.WriteLine(ht[i]);

            foreach (int key in ht.Keys)
                Console.WriteLine($"Marks of RollNo {key} are {ht[key]}");

            ht["ajay"] = 90;


        }
    }
}
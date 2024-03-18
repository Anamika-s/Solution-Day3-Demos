namespace TwoDimensionalArrayDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] num = new int[3, 3];
            //Console.WriteLine("Enter ELements");
            //for (int i = 0; i < num.GetLength(0); i++)
            //{
            //    for (int j = 0; j < num.GetLength(1); j++)
            //    {
            //        num[i, j] = Byte.Parse(Console.ReadLine());
            //    }

            //}


            int[,] num = new int[,] {{1,2,3},
                {4,5,6}, {7,9,3} };
            //Console.WriteLine("Enter ELements");
            //for (int i = 0; i < num.GetLength(0); i++)
            //{
            //    for (int j = 0; j < num.GetLength(1); j++)
            //    {
            //        num[i, j] = Byte.Parse(Console.ReadLine());
            //    }

            //}


            Console.WriteLine("ELements are ");
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
    }
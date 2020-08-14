using System;
using System.Collections.Generic;

namespace RCS_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            List<int> a = new List<int>();
            Console.WriteLine("Randomized list:");
            RandomizeList(a);
            PrintList(a);
            Console.WriteLine();

            FileIO.Write(a);
            List<int> b = FileIO.Read();
            if( b != null)
            {
                Console.WriteLine("Readed list:");
                PrintList(b);
            }
               
        }

        static void RandomizeList(List<int> a)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                a.Add(rand.Next(0, 11));
            }
        }

        static void PrintList(List<int> a)
        {
            foreach (var item in a)
                Console.Write(item + "  ");
        }
    }
}

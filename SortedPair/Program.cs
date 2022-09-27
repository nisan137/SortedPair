using System;
using System.Collections.Generic;

namespace SortedPair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string ans1 = Console.ReadLine();
            Console.WriteLine("Please enter 1 more string");
            string ans2 = Console.ReadLine();

            Sorted_Pair<string> sortedPair = new Sorted_Pair<string>(ans1, ans2);
            List<Sorted_Pair<string>> sortedPairList = new List<Sorted_Pair<string>>();
            sortedPairList.Add(sortedPair);
            printList(sortedPairList);

            Console.WriteLine("----------------------");
            Console.WriteLine("\nThe rules of Sorted Pairs:\nA point will be considered smaller than another point if its x-component\n" +
                "is less than the x-component of the other point,\n" +
                "and its y-component is less than the y-component of the other pointn.\n" +
                "The point will be considered larger than the other point if\n" +
                "its x-component is greater than the x-component of the other point,\n" +
                "and its y-component is greater than the y-component of the other point.\n" +
                "In any other case, the points will be considered equal.\n");

            Random rnd = new Random();
            List<Sorted_Pair<Point>> sortedPairPointList = new List<Sorted_Pair<Point>>();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Sorted_Pair<Point> pair = new Sorted_Pair<Point>
                    (new Point(rnd.Next(0, 100), rnd.Next(0, 100)),
                    new Point(rnd.Next(0, 100), rnd.Next(0, 100)));
                    Console.WriteLine(pair);
                }
                catch (IllegalPairException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();
        }

        public static void printList(List<Sorted_Pair<string>> genericList)
        {
            for (int i = 0; i < genericList.Count; i++)
            {
                Console.Write($"\n{genericList[i]}");
            }
            Console.WriteLine();
        }

    }
    /// <summary>
    /// A point will be considered smaller than another point if its x-component is less than the x-component of the other point,
    /// and its y-component is less than the y-component of the other point.
    /// The point will be considered larger than the other point if its x-component is greater than the x-component of the other point,
    /// and its y-component is greater than the y-component of the other point. In any other case, the points will be considered equal.
    /// </summary>
    struct Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        public int CompareTo(Point other)
        {
            if (this.X < other.X && this.Y < other.Y)
                return -1;
            else if (this.X > other.X && this.Y > other.Y)
                return 1;
            else
                return 0;
        }
    }
}

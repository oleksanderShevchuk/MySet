using System;

namespace MySet
{
    public class Program
    {
        static void Main(string[] args)
        {
            var easySet1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
            var easySet2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
            var easySet3 = new EasySet<int>(new int[] { 3, 4, 5});

            Console.Write("Union: ");
            foreach (var item in easySet1.Union(easySet2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Intersection: ");
            foreach (var item in easySet1.Intersection(easySet2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Difference A \\ B: ");
            foreach (var item in easySet1.Difference(easySet2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Difference B \\ A: ");
            foreach (var item in easySet2.Difference(easySet1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("A Subset C: ");
            Console.Write(easySet1.Subset(easySet3));

            Console.WriteLine();
            Console.Write("C Subset A: ");
            Console.Write(easySet3.Subset(easySet1));

            Console.WriteLine();
            Console.Write("C Subset b: ");
            Console.Write(easySet3.Subset(easySet2));

            Console.WriteLine();
            Console.Write("SymmetricDifference: ");
            foreach (var item in easySet2.SymmetricDifference(easySet1))
            {
                Console.Write(item + " ");
            }
        }
    }
}

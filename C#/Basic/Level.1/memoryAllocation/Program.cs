using System;

namespace memoryAllocation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[3] { 1, 2, 3 };
            var arr2 = arr1;

            arr2[0] = 99;
            Console.WriteLine(arr1[0]);
            Console.WriteLine(string.Format("{0}: {1}", "new", "last"));
        }
    }
}

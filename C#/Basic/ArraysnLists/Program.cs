using System;

namespace ArraysnLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 12, 4, 1, 2, 13, 9, 27, 4, 5, 1,};
            // Length

            Console.WriteLine("Length: " + numbers.Length);

            // Index()
            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine(index);
            // Clear()
            Array.Clear(numbers, 0, 1);
            Console.WriteLine("Effects of Clear()");
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }

            // Copy Method
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effects of Copy()");
            foreach (var num in another)
            {
                Console.WriteLine(num);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effects of Sort()");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effects of Sort()");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

using System;

namespace StringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Dharmendra Rathahhaod ";
            Console.WriteLine("Trimmed: '{0}'",fullName.Trim());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(index);
            Console.WriteLine("{0}: {1}",index, firstName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: {0}",names[0]);
            Console.WriteLine("Last Name: {0}",names[1]);

            Console.WriteLine(fullName.Replace("ha","oO"));

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}

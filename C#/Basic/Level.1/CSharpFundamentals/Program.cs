using CSharpFundamentals.Math;
using System;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var coder = new Person();
            coder.FirstName = "Dharmendra";
            coder.LastName = "Rathod";

            coder.Introduce();

            // 

            Calculator data = new Calculator();
            var result = data.sum(29, 31);
            System.Console.WriteLine(result); ;


            //

            var numbers = new int[5] { 1, 2, 3, 5, 6 };

            numbers[1] = 10;

            System.Console.WriteLine(numbers[1]);


            var flags = new bool[3];

            flags[0] = true;

            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);

            var names = new string[3];

            System.Console.WriteLine(names[0]);

            string list = string.Join(",", numbers);

            System.Console.WriteLine(list);
            String name = "Dharmendra Rathod";

            Int32 i;

            var someNames = new string[3] { "Ass", "Kicker", "LoL" };

            var joinedNames = string.Join("||", someNames);
            Console.WriteLine(joinedNames);

            // verbatim string:
            var text = @"Hi Dear,
  Kindly look into below path:
   C:\Users\rathod\Desktop\sample.db";
            Console.WriteLine(text);


        }
    }
}

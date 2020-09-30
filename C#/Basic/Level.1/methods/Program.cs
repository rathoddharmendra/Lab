using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("DR");

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("String couldn't be converted to number");
        }

        static void UseCalculator()
        {
            // Params
            var calculator = new Calculator();
            var result = calculator.Add(1, 2, 24, 5, 3, 23, 123, 23, 121, 1212);
            Console.WriteLine(result);
        }
        static void UsePoints()
        {
            

            /*// Ref modifier -- Do not use
            var a = 1;
            var calculator1 = new Calculator();
            calculator1.RefModifier(ref a);
            Console.WriteLine(a);*/
            try
            {
                var point = new Point(10, 20);
                point.Display();
                point.Move(null);
                point.Display();
            }
            catch (Exception)
            {

                Console.WriteLine("An exception occured");
            }
        }
    }
}

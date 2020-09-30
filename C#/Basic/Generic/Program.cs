using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Date + " " + today + " " + now);
            Console.WriteLine(now.Minute + " " + now.Hour);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("Tomorrow: " + tomorrow);
            Console.WriteLine("Yesterday: " + yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());

            // Timespan

            var timespan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timespan.ToString());
            var newTime = TimeSpan.Parse("01:02:04");
            Console.WriteLine(newTime - timespan);


        }
    }
}

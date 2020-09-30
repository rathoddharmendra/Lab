using System;

namespace Amazon
{

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            if (rating == 0)
            {
                Console.WriteLine("You are promoted to Lvl.0");
            }
            else if (rating == 1)
            {
                Console.WriteLine("You are promoted to Lvl.1");
            }
            else
            {
                Console.WriteLine("You are promoted to Lvl.2");

            }

        }
    }
}

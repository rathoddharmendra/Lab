using System;

namespace Amazon
{
    public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            var random = new Random();
            var rating = random.Next(0, 2);
            return rating;
        }
    }
}

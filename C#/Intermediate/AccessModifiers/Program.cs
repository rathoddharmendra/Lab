using Amazon;
using Classes;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person(new DateTime(1991, 04, 26));
            //Console.WriteLine($"Age is: {person.Age}");

            //var cookie = new HttpCookie();
            //cookie["name"] = "Dharmendra Rathod";
            //Console.WriteLine(cookie["name"]);

            //var customer = new Customer();
            ////customer.Promote();

            //var calculator = new Amazon.RateCalculator();

            Order order = new Classes.Order();
            Order1 order1 = new Classes.Order1();

            Order order2 = new Classes.Order2();

            //Order2 order3 = new Order();
        }
    }
}

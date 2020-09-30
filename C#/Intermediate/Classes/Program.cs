using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var person = Person.Parse("Dharmendra");
            //person.Introduce("SS");

            //var customer = new Customer(1, "Dharmendra");
            //System.Console.WriteLine(customer.Name);
            //System.Console.WriteLine(customer.Id);
            //var order = new Order();
            //customer.Orders.Add(order);
            //System.Console.WriteLine(customer.Orders);

            //UseParams();
            //UsePoints();

            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            Console.WriteLine(customer.Orders.Count);
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);



        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);

                System.Console.WriteLine($"{point.X} & {point.Y}");
            }
            catch (System.Exception)
            {

                Console.WriteLine("An Unexpected error occurred");
            }
        }

    }
}

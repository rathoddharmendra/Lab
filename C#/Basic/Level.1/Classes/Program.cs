
using Classes.Test;

namespace Classes
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var person = new Person("Piyush");

            Console.WriteLine(person.Name);
                // var person = new Person("Dharmendra");
            // person.Introduce("Ella");

            var customer = new Customer(1,"Soma");
            var order = new Order();
            customer.Orders.Add(order);
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            //object Initializer

            var calculatorObj = new Calculator();

            var customer1 = new Customer
            {
                Id = 2,
                Name = "Dharmendra",
/*                Orders = [Order] order;*/
            };

            customer1.Print();
        }
    }
}

using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            //this.Id = id;
            this.Name = name;
        }

        public void Print()
        {
            System.Console.WriteLine(this.Id);
            System.Console.WriteLine(this.Name);
        }
    }
}

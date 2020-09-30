using System;

namespace Classes
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }
    }
}

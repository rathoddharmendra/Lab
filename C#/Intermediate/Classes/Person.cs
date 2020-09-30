using System;

namespace Classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        public static Person Parse(string name)
        {
            var person = new Person();
            person.Name = name;
            return person;
        }
    }
}

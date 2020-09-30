using System;

namespace Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber) // Need to call base class constructor from derived class as it doesn't come by default
        {
            Console.WriteLine($"Car is being initialized with {registrationNumber}");
        }
    }
}

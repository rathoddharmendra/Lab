using System;

namespace CSharpFundamentals
{
    public class Person
    {
        private const string V = "My Name is: ";
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine(V + FirstName + ' ' + LastName);
        }
    }
}

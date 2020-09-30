using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            const int passwordLength = 15;
            char[] buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)rand.Next(0, 122);
                Console.WriteLine(buffer);
            }
        }
    }
}

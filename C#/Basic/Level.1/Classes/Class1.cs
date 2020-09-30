using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Class
    {
        public int number;
        Calculator calculatorObj = new Calculator();

        public void Introduce()
        {
            Console.WriteLine("My Name is Dharmendra");
            var calculatorObj1 = new Calculator();
        }
    }

    public class Calculator
    {
        public int Calcuate(int a, int b)
        {
            return a + b;
        }
    }

    
}



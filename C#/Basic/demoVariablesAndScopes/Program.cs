using System;

namespace demoVariablesAndScopes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "10";
                //int i = Convert.ToInt32(s);
                byte b = Convert.ToByte(s);
                //int i = int.Parse(s);
                Console.WriteLine(b);


                var number = "1234";
                int i = Convert.ToInt32(number);
                Console.WriteLine("I's Value is " + i);
            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't convert ");
                throw;
                
            }


        }

    }
}

using System;

namespace HelloM3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                var statement = "true";
                bool b = Convert.ToBoolean(statement);
                Console.WriteLine(b);
                
                Console.WriteLine(statement.GetType());
                var number = "1243";
                int i = Convert.ToByte(number);
                // Console.WriteLine(typeof(i));
             
                Console.WriteLine(i);
                
                
            }
            catch (global::System.Exception)
            {

                Console.WriteLine("The number could not be converted into byte code");
            }

            int[] numbers = new int[10] { 0,1,2,3,4,5,6,7,8,9};
            
        }
    }
}
using System;

namespace Enums
{
    public enum ShippingMethod
    {
        Regular,
        Special,
        Premium,
        Extravaganza = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = ShippingMethod.Extravaganza;
            Console.WriteLine(result.ToString());


            var value = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), result.ToString());
            Console.WriteLine((int)value);
        }
    }
}

namespace methods
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var result = 0;
            foreach(var num in numbers)
            {
                result  += num;
            }
            return result;
        }

        public void RefModifier (ref int a)
        {
            a += 10;
        }
    }
}

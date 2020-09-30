using System;
using System.Collections.Generic;

namespace Classes
{
    public class Order
    {
        public static implicit operator List<object>(Order v)
        {
            throw new NotImplementedException();
        }
    }
}

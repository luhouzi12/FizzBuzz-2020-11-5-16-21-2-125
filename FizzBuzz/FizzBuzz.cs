using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Say(int count)
        {
            if (count % 3 == 0)
            {
                return "Fizz";
            }

            if (count % 5 == 0)
            {
                return "Buzz";
            }

            return count.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Say(int count)
        {
            string word = string.Empty;
            if (count % 3 == 0)
            {
                word += "Fizz";
            }

            if (count % 5 == 0)
            {
                word += "Buzz";
            }

            return !string.Equals(word, string.Empty) ? word : count.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata1
{
    public class FizzBuzz
    {
        const int fizzBuzz = 15;
        const int Fizz = 3;
        const int Buzz = 5;
        public string Answer(int p)
        {

            if (isDivisibleBy(p, fizzBuzz))
            {
                return "FizzBuzz";
            }
            if (isDivisibleBy(p, Fizz))
            {
                return "Fizz";
            }
            if (isDivisibleBy(p, Buzz))
            {
                return "Buzz";
            }
            return p.ToString();
        }

        private static bool isDivisibleBy(int p, int j)
        {
            return p % j == 0;
        }
       
        
    }
}

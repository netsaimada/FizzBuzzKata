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
        string[] solutions = new string[] { "FizzBuzz", "Buzz", "Fizz", "{0}" };
        public string Answer(int p)
        {
            FizzRule fizzRule = new FizzRule();

            if (isDivisibleBy(p, fizzBuzz))
            {
                return "FizzBuzz";
            }
            if (fizzRule.check(p))
            {
                return fizzRule.result(p);
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

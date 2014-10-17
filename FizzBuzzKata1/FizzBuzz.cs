using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata1
{
    public class FizzBuzz
    {
        string[] solutions = new string[] { "FizzBuzz", "Buzz", "Fizz", "{0}" };
        public string Answer(int p)
        {
            var a = p % 3;
            var b = p % 5;
            var index = Math.Min(a, 1) + Math.Min(b, 1) * 2;
            return string.Format(solutions[index], p);
        }
    }
}

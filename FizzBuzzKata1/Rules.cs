using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata1
{
    class FizzRule : IRule
    {
        const int fizz = 3;
        const string fizzResult = "Fizz";

        public bool check(int n)
        {
            return isDivisibleBy(n);
        }

        public string result(int n)
        {
            return fizzResult;
        }

        private bool isDivisibleBy(int n)
        {
            return n % fizz == 0; ;
        }
    }
}
